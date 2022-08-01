﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _2_KolekcjeGeneryczne
{

    class PracownikComparer : IEqualityComparer<Pracownik>, IComparer<Pracownik>
    {
        public int Compare([AllowNull] Pracownik x, [AllowNull] Pracownik y)
        {
            return String.Compare(x.Nazwisko, y.Nazwisko);
        }

        public bool Equals([AllowNull] Pracownik x, [AllowNull] Pracownik y)
        {
            return String.Equals(x.Nazwisko, y.Nazwisko);
        }

        public int GetHashCode([DisallowNull] Pracownik obj)
        {
            return obj.Nazwisko.GetHashCode();
        }
    }
}
