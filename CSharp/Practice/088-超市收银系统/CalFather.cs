﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _088_超市收银系统
{
    /// <summary>
    /// 打折的父类
    /// </summary>
    abstract class CalFather
    {
        /// <summary>
        /// 计算打折后应付多少钱
        /// </summary>
        /// <param name="realMoney">打折前应付的钱</param>
        /// <returns>返回打折后的钱</returns>
        public abstract double GetTotalMoney(double realMoney);
    }
}
