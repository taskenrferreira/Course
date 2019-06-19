﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities.Enums
{
    enum OrderStatus : int
    {
        PaymentPending = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
