using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db.Classes
{
    internal class VideoCard
    {
        [DisplayName("id")]
        public string id { get; set; }

        [DisplayName("Графический CPU")]
        public string GCPU { get; set; }

        [DisplayName("Объем памяти")]
        public int volumeMemory { get; set; }

        [DisplayName("Тип памяти")]
        public string typeMemory { get; set; }

        [DisplayName("Частота памяти")]
        public int frequencyMemory { get; set; }

        private int _power;
        [DisplayName("Мощность")]
        public int Power
        {
            get { return _power; }
            set { _power = value; }
        }


        [DisplayName("Название")]
        public string title { get; set; }

        [DisplayName("Производитель")]
        public string manufacturer { get; set; }

        public VideoCard()
        {
            id = Guid.NewGuid().ToString();
        }

        public VideoCard(string gCPU, int volumeMemory, string typeMemory, int frequencyMemory, int power, string title, string manufacturer)
        {
            id = Guid.NewGuid().ToString();
            GCPU = gCPU;
            this.volumeMemory = volumeMemory;
            this.typeMemory = typeMemory;
            this.frequencyMemory = frequencyMemory;
            this.Power = power;
            this.title = title;
            this.manufacturer = manufacturer;
        }
    }
}
