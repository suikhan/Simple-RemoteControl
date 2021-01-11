namespace RFC
{
    class Globle
    {
        public static int Port = 9999;                      //默认上线端口
        public static int UDP_Port = 9999;                      //默认上线端口
        public static string Host = "192.168.3.5";            //默认主控端地址
        public static string Software = "专用版本";         //软件版本
        public static string Customer = "无";               //客户端注释
        public static bool _IsListen_Port = true;           //是否监听端口
        public static bool _IsResvice_Message = true;       //是否接收消息
        public static int Lis_Port = 6666;                  //自身监听端口
    }
}
