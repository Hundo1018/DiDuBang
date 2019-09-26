using System;
using System.Collections;
using System.Collections.Generic;
namespace Fibroin
{
    /// <summary>
    /// 網
    /// </summary>
    public class Web
    {

        public List<Node> nodes;
        public Web()
        {
            List<Line<Time>> timeLine;
            List<Line<Space>> spaceLine;
            List<Node> nodes;
        }
    }
    /// <summary>
    /// 基礎型別:單位
    /// </summary>
    public class Unit
    {
        public Time time;//此單位存在的時間
        public Space space;//此單位存在的空間
        public List<string> alias;//對此單位的別稱
        public string description;//對此單位的描述(第三人稱)
        public List<Unit> Perception;//此單位感知到的其他單位
        public List<string> DescriptionAnalysis()//描述解析
        {
            return null;
        }
    }
    /// <summary>
    /// 時間
    /// 時間能感知到在其之上的空間線
    /// </summary>
    public class Time : Unit
    {
        public void GetSpaceLine()
        {
        }
    }
    /// <summary>
    /// 空間
    /// 空間能感知道在其之上的時間線
    /// </summary>
    public class Space : Unit
    {
        public void GetTimeLine()
        {
        }
    }
    /// <summary>
    /// 事件 
    /// </summary>
    public class Event : Unit
    {

    }
    /// <summary>
    /// 線的集合,表示關聯
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Line<T>
    {
        public List<T> SameObjectsOnLine;
    }
    /// <summary>
    /// 節點,縱線與橫線交錯處,表示同時空下事件集合發生處
    /// </summary>
    public class Node : Unit
    {
        public Line<Event> events;//當下所發生的事件集合
        public Line<Time> timeLine;//與此事件集合相同的時間線
        public Line<Space> spaceLine;//與此事件集合相同的空間線
    }
}
