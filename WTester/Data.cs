using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace WTester {
    /// <summary>
    /// データ
    /// </summary>
    public class Data {
        public List<DataEntry> Entries = new List<DataEntry>();

        /// <summary>
        /// 読み込み
        /// </summary>
        public static Data Deserialize(string fileName) {
            try {
                using (FileStream stream = File.OpenRead(fileName)) {
                    return (Data)new XmlSerializer(
                        typeof(Data)).Deserialize(stream);
                }
            } catch (FileNotFoundException) {
                return new Data();
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        public void Serialize(string fileName) {
            using (FileStream stream = File.Create(fileName)) {
                new XmlSerializer(this.GetType()).Serialize(stream, this);
            }
        }
    }
    /// <summary>
    /// データ1項目
    /// </summary>
    public class DataEntry {
        public string Name;
        public string Text1;
        public string Text2;
        public string Text3;
        public string Text4;

        public override string ToString() { return Name; }
    }
}
