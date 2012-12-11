using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace RestApi.Models.Abstract
{
    public interface IEntity
    {
        int ID { get; set; }
    }
}