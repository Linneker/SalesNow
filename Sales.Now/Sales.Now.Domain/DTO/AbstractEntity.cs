using System;
using System.Collections.Generic;
using System.Text;

namespace Sales.Now.Domain.DTO
{
    public  class AbstractEntity
    {
        public AbstractEntity()
        {
            if (DataCriacao is null)
            {
                DataCriacao = DateTime.Now;
                Id = Guid.NewGuid();
            }
            else
                DataModificacao = DateTime.Now;
        }
        public virtual Guid Id { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataModificacao { get; set; }
        public DateTime? DataInativacao { get; set; }

        public EnumStatus Status { get; set; }
    }
}
