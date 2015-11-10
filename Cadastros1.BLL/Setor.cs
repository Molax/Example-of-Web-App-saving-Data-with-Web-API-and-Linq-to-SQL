using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastros1.Dto;
using Cadastros1.DAL;

namespace Cadastros1.BLL
{
    public class Setor
    {
        public int CreateNewSetcor(ViewModel.CreateNewSector Setor)
        {
            return new DAL.Setor().CreateNewSector(new Dto.Setor {
            
                Nome = Setor.sSetor

            });
        }
    }
}
