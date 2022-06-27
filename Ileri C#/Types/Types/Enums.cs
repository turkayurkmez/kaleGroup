using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public enum OrderState
    {
        Pending,
        Success,
        Failed
    }

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right

    }

    public enum ErkekAkrabalikTipleri
    {
        Abi = 1,
        Ogul = 2,
        Baba = 4,
        Amca = 8,
        Dayı = 16,
        Dede = 32

    }





}
