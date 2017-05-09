using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ISLibrary
{
    public class GlobalSettings
    {
        public GlobalSettings()
        {
            ConnectionSettingsCollection = new Dictionary<ConnectionSettings, ConnectionSetting>();
            UserCredentialsCollection = new Dictionary<UserCredentials, UserCredential>();
        }
        public static GlobalSettings CreateWithDefaults()
        {
            GlobalSettings gs = new GlobalSettings();
            gs.ConnectionSettingsCollection.Add(ConnectionSettings.pgsqlAnt, new ConnectionSetting()
            {
                Name = ((XmlEnumAttribute)typeof(ConnectionSettings).GetMember(ConnectionSettings.pgsqlAnt.ToString())[0]
                        .GetCustomAttributes(typeof(XmlEnumAttribute), false)[0]).Name,
                ProviderName = "System.Data.Odbc",
                ConnectionString = "Driver={PostgreSQL UNICODE};Server=ant;Port=5432;Database=test;Integrated Security=false;"
            });
            gs.ConnectionSettingsCollection.Add(ConnectionSettings.mssqlMpa, new ConnectionSetting()
            {
                Name = ((XmlEnumAttribute)typeof(ConnectionSettings).GetMember(ConnectionSettings.mssqlMpa.ToString())[0]
                        .GetCustomAttributes(typeof(XmlEnumAttribute), false)[0]).Name,
                ProviderName = "System.Data.SqlClient",
                ConnectionString = "server=mpa;Initial Catalog=clipperData;Persist Security Info=false;Integrated Security=false;"
            });
            gs.UserCredentialsCollection.Add(UserCredentials.pgsqlAntIskrasystems, new UserCredential()
            {
                Name = ((XmlEnumAttribute)typeof(UserCredentials).GetMember(UserCredentials.pgsqlAntIskrasystems.ToString())[0]
                           .GetCustomAttributes(typeof(XmlEnumAttribute), false)[0]).Name,
                ConnectionSetting = ConnectionSettings.pgsqlAnt,
                UserName = "iskrasystems",
                Password = "whrahz5q"
            });
            return gs;
        }
        public static GlobalSettings ReadFromXml(string fullXmlFileName)
        {
            GlobalSettings gs = new GlobalSettings();
            var xmlReaderSettings = new XmlReaderSettings() { IgnoreComments = true };
            using (var xmlStreamReader = new System.IO.StreamReader(fullXmlFileName))
            using (var xmlReader = XmlReader.Create(xmlStreamReader, xmlReaderSettings))
            {
                xmlReader.ReadToFollowing("connection-settings");
                XmlSerializer csSerializer = new XmlSerializer(typeof(ConnectionSetting[]), new XmlRootAttribute() { ElementName = "connection-settings" });
                gs.ConnectionSettingsCollection = ((ConnectionSetting[])csSerializer.Deserialize(xmlReader)).ToDictionary(
                    i => (ConnectionSettings)Enum.Parse(typeof(ConnectionSettings), i.Name, true),
                    i => new ConnectionSetting()
                    {
                        Name = i.Name,
                        ProviderName = i.ProviderName,
                        ConnectionString = i.ConnectionString
                    });
                xmlReader.ReadToFollowing("user-credentials");
                XmlSerializer ucSerializer = new XmlSerializer(typeof(UserCredential[]), new XmlRootAttribute() { ElementName = "user-credentials" });
                gs.UserCredentialsCollection = ((UserCredential[])ucSerializer.Deserialize(xmlReader)).ToDictionary(
                    i => (UserCredentials)Enum.Parse(typeof(UserCredentials), i.Name, true),
                    i => new UserCredential()
                    {
                        Name = i.Name,
                        ConnectionSetting = i.ConnectionSetting,
                        UserName = i.UserName,
                        Password = StringEncryptor.DecryptWithByteArray(i.Password)
                    });
            };

            //XmlSerializer serializer = new XmlSerializer(typeof(ConnectionSetting[]), new XmlRootAttribute() { ElementName = "ConnectionSettings" });
            //gs.ConnectionSettingsCollection = ((ConnectionSetting[])serializer.Deserialize(wfile)).ToDictionary(i => (ConnectionSettings)Enum.Parse(typeof(ConnectionSettings), i.Name, true), i => new ConnectionSetting() { Name = i.Name });
            //var value = ConnectionSettings.mssqlMpa;
            //var attributeValue = ((XmlEnumAttribute)typeof(ConnectionSettings)
            //            .GetMember(value.ToString())[0]
            //            .GetCustomAttributes(typeof(XmlEnumAttribute), false)[0])
            //            .Name;
            //var a = gs.ConnectionSettingsCollection[ConnectionSettings.mssqlMpa];
            return gs;
        }
        public bool WriteToXml(string fullXmlFileName)
        {
            var xmlWriterSettings = new XmlWriterSettings() { Indent = true, OmitXmlDeclaration = true, NewLineOnAttributes = true };
            using (var xmlStreamWriter = new System.IO.StreamWriter(fullXmlFileName))
            using (var xmlWriter = XmlWriter.Create(xmlStreamWriter, xmlWriterSettings))
            {
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");//to remove default namespaces in root element of array while serialize collections

                xmlWriter.WriteStartElement("settings");
                #region connection-settings section: ConnectionSettings dictionary serialization
                XmlSerializer csSerializer = new XmlSerializer(typeof(ConnectionSetting[]), new XmlRootAttribute() { ElementName = "connection-settings" });
                //csSerializer.Serialize(xmlWriter, ConnectionSettingsCollection.Select(cs =>
                //    new ConnectionSetting()
                //    {
                //        Name = ((ConnectionSetting)cs.Value).Name,
                //        ProviderName = ((ConnectionSetting)cs.Value).ProviderName,
                //        ConnectionString = ((ConnectionSetting)cs.Value).ConnectionString,
                //    })
                //    .ToArray(), ns);
                csSerializer.Serialize(xmlWriter, ConnectionSettingsCollection.Values.ToArray(), ns);
                #endregion
                #region user-credentials section: UserCredentials dictionary serialization
                XmlSerializer ucSerializer = new XmlSerializer(typeof(UserCredential[]), new XmlRootAttribute() { ElementName = "user-credentials" });
                ucSerializer.Serialize(xmlWriter, UserCredentialsCollection.Values.Select(v => { v.Password = StringEncryptor.EncryptWithByteArray(v.Password); return v; }).ToArray(), ns);
                #endregion

                xmlWriter.WriteEndElement();
            };
            return true;
        }
        public Dictionary<ConnectionSettings, ConnectionSetting> ConnectionSettingsCollection { get; set; }
        public Dictionary<UserCredentials, UserCredential> UserCredentialsCollection { get; set; }
    }

    public enum ConnectionSettings
    {
        [XmlEnum(Name = "pgsqlAnt")]
        pgsqlAnt,
        [XmlEnum(Name = "mssqlMpa")]
        mssqlMpa
    };
    public enum UserCredentials
    {
        [XmlEnum(Name = "pgsqlAntIskrasystems")]
        pgsqlAntIskrasystems
    };
    [XmlRoot("connection-settings")]
    [XmlType("add")]
    public class ConnectionSetting
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("provider-name")]
        public string ProviderName { get; set; }
        [XmlAttribute("connection-string")]
        public string ConnectionString { get; set; }
    }
    [XmlRoot("user-credentials")]
    [XmlType("add")]
    public class UserCredential
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("connection-setting")]
        public ConnectionSettings ConnectionSetting { get; set; }
        [XmlAttribute("user-name")]
        public string UserName { get; set; }
        [XmlAttribute("password")]
        public string Password { get; set; }
    }
}
