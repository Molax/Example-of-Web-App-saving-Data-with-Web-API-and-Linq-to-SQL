using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastros1.DATA;

namespace Cadastros1.DAL
{
    public class Setor
    {
        public int CreateNewSector(Dto.Setor setor)
        {
            using (var db = new DATA.Cadastros1DataContext())
            {
                var dbSetor = new DATA.tblSetor {
                
                    sSetor = setor.Nome

                };

                db.tblSetors.InsertOnSubmit(dbSetor);

                db.SubmitChanges();

                return dbSetor.nldSetor;
            }
        }
    }
}
