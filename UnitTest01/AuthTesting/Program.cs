

namespace AuthTesting;

public class Program{

    static void Main( string[] args ) {

    }

    public static string Something() {
        return "Algo";
    }

    public static bool Login(string user, string pass) {
        return (user == "dpalacios" && pass == "123456") ? true : false;
    }

}