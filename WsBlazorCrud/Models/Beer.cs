using System;
using System.Collections.Generic;

namespace WsBlazorCrud.Models;

public partial class Beer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Brand { get; set; } = null!;
}
