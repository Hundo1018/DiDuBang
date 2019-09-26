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
            List<Line<Time>> timeArea;
            List<Line<Space>> spaceArea;
            List<Node> nodes;
            timeArea = new List<Line<Time>>();
            spaceArea = new List<Line<Space>>();
            
        }
    }


    /// <summary>
    /// 抽象基礎型別:單位
    /// </summary>
    public abstract class Unit
    {
        public List<string> alias;//對此單位的別稱
        public string description;//對此單位的描述(第三人稱)
        public Time time;//此單位存在的時間
        public Space space;//此單位存在的空間
        public List<Unit> Perception;//此單位感知到的其他單位
        public virtual List<string> DescriptionAnalysis()//描述解析方法(可覆寫的)
        {
            return null;
        }
        public Unit()
        {

        }
    }

    /// <summary>
    /// 時間系統
    /// </summary>
    public abstract class TimeSystem
    {
        string name;
        double carry;
        List<double> timeLayer;//時間層級,可自行定義(大小,時間單位)

        /// <summary>
        /// 
        /// </summary>
        public TimeSystem()
        {

        }
         
    }
    
    /// <summary>
    /// 空間系統
    /// </summary>
    public abstract class SpaceSystem
    {

    }



    /// <summary>
    /// 時間點
    /// 時間能感知到在其之上的空間線
    /// </summary>
    public class Time : TimeSystem
    {

        //多載運算子來運算時間
        //以及判斷時間點是否在其他兩時間點之間
        TimeSystem now;
        public void GetSpaceLine()
        {

        }
    }
   
    /// <summary>
    /// 空間區域
    /// 空間能感知道在其之上的時間線
    /// </summary>
    public class Space : Unit
    {
        List<Space> parents;
        List<Space> childs;
        public void GetTimeLine()
        {

        }
    }
   
    /// <summary>
    /// 事件 
    /// 事件包含區域與時間長度
    /// </summary>
    public class Event : Unit
    {

    }

    /// <summary>
    /// 線的集合
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Line<T> where T : Unit
    {
        //
        public List<T> UnitSet;//單位集合

        void asd()
        {

        }
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
