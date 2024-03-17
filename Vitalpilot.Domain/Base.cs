using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitalpilot.Domain
{
    public abstract class Base<TEntity> where TEntity : IBase
    {
        public abstract TEntity CreateNew();

        public abstract void Update(TEntity entity);

        public abstract void Delete();
    }
}