
using Newtonsoft.Json.Converters;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Movies.Application.ViewModels
{
    public enum MPAA
    {
        G,
        PG,
        PG13,
        R
    }

    public enum Genre
    {
        Action,
        Children,
        Comedy,
        Drama,
        Romance,
        RomanticComedy
    }
}
