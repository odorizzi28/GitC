﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView.Model
{
    public class Venda { 
    public string Carro { get; set; }
    public int Quantidade { get; set; }
    public double Valor { get; set; }
    public bool Ativo { get; set; }
    public int UsuInc { get; set; }
    public int UsuAlt { get; set; }
    public DateTime DatInc { get; set; } = DateTime.Now;
    public DateTime DatAlt { get; set; } = DateTime.Now;
    
    }
}
