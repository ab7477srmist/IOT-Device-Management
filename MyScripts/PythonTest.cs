using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Scripting.Python;
using TMPro;

public class PythonTest : MonoBehaviour
{
    [SerializeField] private UIManager ui;
    private string _ww;

    static void Print()
    {
        PythonRunner.RunString(@"
import UnityEngine
import mysql.connector
#UnityEngine.Debug.Log('hello world')
#if UnityEngine.GameObject.FindGameObjectWithTag(""MainCamera""):
#    UnityEngine.Debug.Log(""one"")
#_ww = UnityEngine.GameObject.Find(""UI Manager"").GetComponent(""UIManager"")._w.text
#UnityEngine.Debug.Log(_ww)
mydb = mysql.connector.connect(
  host=""localhost"",
  user=""root"",
  password=""aditya@123"",
  database=""iot""
)
#UnityEngine.Debug.Log(mydb)
mycursor = mydb.cursor()
mycursor.execute(""Select name from watch1 where id='5'"")
result =  mycursor.fetchone()
result_str = ""\n"".join([str(row) for row in result])
UnityEngine.Debug.Log(result_str)
UnityEngine.GameObject.Find(""UI Manager"").GetComponent(""UIManager"")._w1.text=result_str;

mycursor.execute(""Select status from watch1 where id='5'"")
result =  mycursor.fetchone()
result_str = ""\n"".join([str(row) for row in result])
UnityEngine.GameObject.Find(""UI Manager"").GetComponent(""UIManager"")._w1s.text=result_str;

mycursor.execute(""Select battery from watch1 where id='5'"")
result =  mycursor.fetchone()
result_str = ""\n"".join([str(row) for row in result])
UnityEngine.GameObject.Find(""UI Manager"").GetComponent(""UIManager"")._w1b.text=result_str;

mycursor.execute(""Select blood from watch1 where id='5'"")
result =  mycursor.fetchone()
result_str = ""\n"".join([str(row) for row in result])
UnityEngine.GameObject.Find(""UI Manager"").GetComponent(""UIManager"")._w1bl.text=result_str;

mycursor.execute(""Select company from watch1 where id='5'"")
result =  mycursor.fetchone()
result_str = ""\n"".join([str(row) for row in result])
UnityEngine.GameObject.Find(""UI Manager"").GetComponent(""UIManager"")._w1c.text=result_str;

mycursor.execute(""Select securitykey from security where id=5"")
result =  mycursor.fetchone()
result_str = ""\n"".join([str(row) for row in result])
UnityEngine.GameObject.Find(""UI Manager"").GetComponent(""UIManager"")._w1se.text=result_str;

                ");
        //PythonRunner.RunFile($"D:/test1.py");

    }

    public static void Enter()
    {
        PythonRunner.RunString(@"
import UnityEngine
import mysql.connector
mydb = mysql.connector.connect(
  host=""localhost"",
  user=""root"",
  password=""aditya@123"",
  database=""iot""
)
UnityEngine.Debug.Log(mydb)

name = UnityEngine.GameObject.Find(""UI Manager"").GetComponent(""UIManager"")._cw1.text
status = UnityEngine.GameObject.Find(""UI Manager"").GetComponent(""UIManager"")._cw1s.text
battery = UnityEngine.GameObject.Find(""UI Manager"").GetComponent(""UIManager"")._cw1b.text
blood = UnityEngine.GameObject.Find(""UI Manager"").GetComponent(""UIManager"")._cw1bl.text
company = UnityEngine.GameObject.Find(""UI Manager"").GetComponent(""UIManager"")._cw1c.text

mycursor = mydb.cursor()
sql = ""Update watch1 set name = %s, status=%s, battery=%s, blood=%s,company=%s where id='5'"";
val = (name,status,battery,blood,company)
mycursor.execute(sql,val)
mydb.commit()

");
        Print();
    }

    private void Start()
    {
        //_ww = GameObject.Find("UI Manager").GetComponent<UIManager>()._w.text;
        //Debug.Log(_ww);
        Print();
    }

    private void Update()
    {
        
    }

}
