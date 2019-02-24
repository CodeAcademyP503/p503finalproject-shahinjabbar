let script1= document.createElement("script");
script1.src="js/kommunal-az.js";
let script2= document.createElement("script");
script2.src="js/mobile-az.js";
let script3= document.createElement("script");
script3.src="js/bank-az.js";
let script4= document.createElement("script");
script4.src="js/country-az.js";
let script5= document.createElement("script");
script5.src="js/tv-az.js";
let script6= document.createElement("script");
script6.src="js/internet-az.js";
let script7= document.createElement("script");
script7.src="js/phone-az.js";
let script8= document.createElement("script");
script8.src="js/fun-az.js";
let script9= document.createElement("script");
script9.src="js/wallet-az.js";

if (localStorage.getItem("base").toString() == "kommunal") {
    let script = document.getElementById("script");
    document.body.removeChild(script);
    document.body.appendChild(script1);
}
if (localStorage.getItem("base").toString() == "mobile") {
    let script = document.getElementById("script");
    document.body.removeChild(script);
    document.body.appendChild(script2);
}
if (localStorage.getItem("base").toString() == "bank") {
    let script = document.getElementById("script");
    document.body.removeChild(script);
    document.body.appendChild(script3);
}
if (localStorage.getItem("base").toString() == "country") {
    let script = document.getElementById("script");
    document.body.removeChild(script);
    document.body.appendChild(script4);
}
if (localStorage.getItem("base").toString() == "tv") {
    let script = document.getElementById("script");
    document.body.removeChild(script);
    document.body.appendChild(script5);
}
if (localStorage.getItem("base").toString() == "internet") {
    let script = document.getElementById("script");
    document.body.removeChild(script);
    document.body.appendChild(script6);
}
if (localStorage.getItem("base").toString() == "telefon") {
    let script = document.getElementById("script");
    document.body.removeChild(script);
    document.body.appendChild(script7);
}
if (localStorage.getItem("base").toString() == "fun") {
    let script = document.getElementById("script");
    document.body.removeChild(script);
    document.body.appendChild(script8);
}
if (localStorage.getItem("base").toString() == "wallet") {
    let script = document.getElementById("script");
    document.body.removeChild(script);
    document.body.appendChild(script9);
}
if (localStorage.getItem("base").toString() == "kommunalru") {
    init9();
}
if (localStorage.getItem("base").toString() == "mobileru") {
    init10();
}
if (localStorage.getItem("base").toString() == "bankru") {
    init11();
}
if (localStorage.getItem("base").toString() == "countryru") {
    init12();
}
if (localStorage.getItem("base").toString() == "tvru") {
    init13();
}
if (localStorage.getItem("base").toString() == "internetru") {
    init14();
}
if (localStorage.getItem("base").toString() == "phoneru") {
    init15();
}
if (localStorage.getItem("base").toString() == "funru") {
    init16();
}
if (localStorage.getItem("base").toString() == "walletru") {
    init17();
}
if (localStorage.getItem("base").toString() == "kommunalen") {
    init18();
}
if (localStorage.getItem("base").toString() == "mobileen") {
    init19();
}
if (localStorage.getItem("base").toString() == "banken") {
    init20();
}
if (localStorage.getItem("base").toString() == "countryen") {
    init21();
}
if (localStorage.getItem("base").toString() == "tven") {
    init22();
}
if (localStorage.getItem("base").toString() == "interneten") {
    init23();
}
if (localStorage.getItem("base").toString() == "phonen") {
    init24();
}
if (localStorage.getItem("base").toString() == "funen") {
    init25();
}
if (localStorage.getItem("base").toString() == "walleten") {
    init26();
}