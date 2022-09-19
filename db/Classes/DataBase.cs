using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db.Classes
{
    class DataBase
    {
        const String filename = @"pcBuild.yap";
        IObjectContainer db;
        public void dbConnect()
        {
            db = Db4oFactory.OpenFile(filename);
            db.Ext().Configure().ObjectClass(typeof(PC)).CascadeOnActivate(true);
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
    }
}
