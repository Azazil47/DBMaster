using DBMaster;
using System;
using System.Collections.Generic;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;

public static class ServiceClass // : ServiceController
{
    public static void Start(String name)
    {
        ServiceController service = new ServiceController(name);
        
        try
        {
            if(service.Status.Equals(ServiceControllerStatus.Stopped))
            {
                service.Start();
                //MyLoger.write($"{MyLoger.MyEnum.INFO}\tСлужба {service.DisplayName}\tСтатус: ЗАПУСКАЕТСЯ");
                Program.myForm.textBoxLog.Text += 
                    $"{DateTime.Now.ToString("HH:mm:ss")} - {MyLoger.MyEnum.INFO} Служба \"{service.DisplayName}\": ЗАПУСКАЕТСЯ\r\n";
                while(true)
                {
                    service.Refresh();
                    if(service.Status == ServiceControllerStatus.Running)
                    {
                       // MyLoger.write($"{MyLoger.MyEnum.INFO}\tСлужба {service.DisplayName}\tСтатус: ЗАПУЩЕНА");
                        Program.myForm.textBoxLog.Text +=
                            $"{DateTime.Now.ToString("HH:mm:ss")} - {MyLoger.MyEnum.INFO} Служба \"{service.DisplayName}\": ЗАПУЩЕНА\r\n";
                        break;
                    }
                }
            }else
            {
               // MyLoger.write($"{MyLoger.MyEnum.WARNING}\tСлужба \"{name}\" не может быть запущена");
                Program.myForm.textBoxLog.Text += 
                    $"{DateTime.Now.ToString("HH:mm:ss")} - {MyLoger.MyEnum.WARNING} Служба \"{name}\" не может быть запущена\r\n";
            }
        }
        catch (Exception)
        {
            DialogResult dialog = MessageBox.Show($"\"{name}\" с этой службой, что-то не так.","Предупреждение",MessageBoxButtons.YesNo, MessageBoxIcon.Error);
           // MyLoger.write($"{MyLoger.MyEnum.ERROR}\t Попытка запустить службу \"{name}\" привела к страшным последствиям");
            Program.myForm.textBoxLog.Text +=
                    $"{DateTime.Now.ToString("HH:mm:ss")} - {MyLoger.MyEnum.WARNING} Служба \"{name}\" \r\n";
            if(dialog == DialogResult.Yes)
            {
                //УДАЛИТЬ службы из файла конфигурации
            } else
            {
                //ОСТАВИТЬ ВСЕ КАК ЕСТЬ
            }
        }
    }

    public static void Stop(String name)
    {
        ServiceController service = new ServiceController(name);
        try
        {
            if(service.Status.Equals(ServiceControllerStatus.Running))
                { 
                service.Stop();
                int sec = 30;
                while (!service.Status.Equals(ServiceControllerStatus.Stopped)) //Ожидание изменения статуса службы
                {
                    Thread.Sleep(1000);
                    service.Refresh();
                    if (sec-- == 10) break;
                }
                if (sec > 0)
                { //GOOD
                    MyLoger.writeFile(0, "служба", service.DisplayName, service.Status);
                    MyLoger.writeTextBox(0, "служба", service.DisplayName, service.Status);
                }
                else
                { //FAILT
                    MyLoger.writeFile(-1, "служба", service.DisplayName, service.Status);
                    MyLoger.writeTextBox(-1, "служба", service.DisplayName, service.Status);
                }
            } else
            {
                MyLoger.writeFile(-1, "служба", name, "не может быть остановлена");
                MyLoger.writeTextBox(-1, "служба", name, "не может быть остановлена");
            }
            
        }
        catch (Exception)
        {
            DialogResult dialog = MessageBox.Show($"Со этой службой \"{name}\", что-то не так. \r\n Удалить ее?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            MyLoger.writeFile(-1, "служба", name, "не может быть остановлена");
            MyLoger.writeTextBox(-1, "служба", name, "не может быть остановлена");
        }
    }

    public static void StopAll(List<String[]> list)
    {
        foreach (String[] item in list)
        {
            Stop(item[0]);
        }
    }

    public static void StartAll(List<String[]> list)
    {
        foreach (String[] item in list)
        {
            Start(item[0]);
        }

    }


    public static String Status(String name)
    {
        ServiceController service = new ServiceController(name);
        try
        {
            service.Refresh();
            //MyLoger.write($"{MyLoger.MyEnum.INFO}\tСлужба: {service.DisplayName} \tСтатус: {service.Status.ToString()}");
            return service.Status.ToString();
        }
        catch (Exception)
        {
            return "Служба не найдена";
        }
    }

    public static void Refresh(String name)
    {
        ServiceController service = new ServiceController(name);

        service.Refresh();
    }


}

