using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;

namespace db.Classes
{
    class DataBase
    {
        const String filename = @"pcBuild.yap";
        IObjectContainer db;
        public void dbConnect()
        {
            db = Db4oFactory.OpenFile(filename);
        }
        public void dbClose()
        {
            db.Close();
        }
        #region Работа с материнской платой
        public void addMotherBoard(MotherBoard motherBoard)
        {
            db.Store(motherBoard);
        }
        public List<MotherBoard> getMotherBoard()
        {
            return db.Query<MotherBoard>().ToList();
        }

        internal void deleteMotherBoard(string id)
        {
            var example = new MotherBoard();
            example.id = id;
            var found = db.QueryByExample(example).Next() as MotherBoard;
            db.Delete(found);
        }

        internal void updateMotherBoard(MotherBoard mb)
        {
            var example = new MotherBoard();
            example.id = mb.id;
            var found = db.QueryByExample(example).Next() as MotherBoard;
            found.manufacturer = found.manufacturer;
            found.RAMtype = mb.RAMtype;
            found.socket = mb.socket;
            found.title = mb.title;
            found.GCPUtype = mb.GCPUtype;
            db.Store(found);
        }
        #endregion
        #region Работа с процессором
        public void AddCPU(CPU cpu)
        {
            db.Store(cpu);
        }
        public void DeleteCPU(string id)
        {
            var found = db.Query<CPU>(cpu => cpu.id == id);
            db.Delete(found);
        }
        public List<CPU> GetCPU()
        {
            return db.Query<CPU>().ToList();
        }
        #endregion
        #region
        public void AddVideoCard(VideoCard vc)
        {
            db.Store(vc);
        }

        public void DeleteVideoCard(string id)
        {
            var found = db.Query<VideoCard>(vc => vc.id == id)[0];
            db.Delete(found);
        }
        public List<VideoCard> GetVideoCard() => db.Query<VideoCard>().ToList();
        #endregion

        #region
        public void AddPowerBlock(PowerBlock pb)
        {
            db.Store(pb);
        }
        public void DeletePowerBlock(string id)
        {
            var found = db.Query<PowerBlock>(pb => pb.id == id)[0];
            db.Delete(found);
        }
        public List<PowerBlock> GetPowerBlocks() => db.Query<PowerBlock>().ToList();
        #endregion

        #region Работа с ПЗУ
        public void AddStorage(Storage storage)
        {
            db.Store(storage);
        }

        public void DeleteStorage(string id)
        {
            var proto = new Storage();
            proto.id = id;
            proto.manufacturer = null;
            proto.title = null;
            proto.type = null;
            proto.speedOfRead = 0;
            proto.speedOfWrite = 0;
            proto.volune = 0;
            var found = db.QueryByExample(proto).Next() as Storage;
            db.Delete(found);
        }

        public List<Storage> GetSrorage() => db.Query<Storage>().ToList();
        #endregion
    }
}
