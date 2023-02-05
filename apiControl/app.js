const express=require("express");
const app=express();
const spawn=require("child_process").spawn;
const net = spawn("./ApiControl/bin/Debug/ApiControl.exe");
/*
net.stdout.on('data',(data)=>{
    console.log("Recibi de .neteste mensaje: "+data.toString());
});*/
app.get("/control",(req,res)=>{
    /*var respuesta=req.param("tecla");
    console.log(respuesta);
    res.send(respuesta)*/
    
    console.log("recibe una solicitud de: "+req.param("tecla"));
    net.stdin.write(req.param("tecla"));
    net.stdout.on('data',(data)=>{
        console.log("tecla: "+data.toString());
    });
    res.send("hola");
})
app.listen(3000,()=>{console.log("server corriendo")});