public class Console
{
    public string valor = "null";
    public string ping_google = @"/C " + "ping 8.8.8.8 -t & pause";
    public string ping_cloudflare = @"/C " + "ping 1.1.1.1 -t & pause";
    public string ping_routers = @"/C " + "ping 192.168.0.1 -t & pause";
    public string remover_ip = @"/C " + "ipconfig /release & pause";
    public string renovar_ip = @"/C " + "ipconfig /renew & pause";
    public string ip_config = @"/C " + "ipconfig & pause";
    public string interromper_desligamento = @"/C " + "shutdown -a";
    public string verificar_erros_win = @"/C " + "sfc /scannow & pause";
    public string limpar_arquivos_temp = @"/C " + "cleanmgr & pause";
    public string retorno = "0";
    public int cont_mtu = 1500;



    public string PingUsuario(string valor)
    {
        return @"/C " + "ping " + valor + " -t & pause";
    }
    public string DesligarTempo()
    {
        return @"/C " + "shutdown -s -t " + valor;
    }

    public string ChecarDisco()
    {
        return @"/C " + "chkdsk " + valor + ": /r /f & pause";
    }

    public string MelhorMtu()
    {
        return @"/C " + "ping www.google.com -f -l " + valor + "& pause";
    }
    public string ConverterUnidade()
    {
        return @"/C " + "convert " + valor + ": /v /fs:ntfs /nosecurity /x & pause";
    }
}

