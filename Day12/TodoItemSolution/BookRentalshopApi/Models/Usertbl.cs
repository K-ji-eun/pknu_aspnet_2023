﻿using System;
using System.Collections.Generic;

namespace BookRentalshopApi.Models;

public partial class Usertbl
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string Password { get; set; } = null!;
}
