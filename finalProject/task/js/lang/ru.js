var mainWidth = 1200;
var secondWidth = 700;
var arry = [
  {
    tagName: "div",
    backColor: "rgb(5,72,153)",
    logo: "images/socar.png"
  },
  {
    tagName: "div",
    backColor: "rgb(29,135,198)",
    logo: "images/AZERSU logo.png"
  },
  {
    tagName: "div",
    backColor: "rgb(192, 178, 250)",
    logo: "images/Azercell_logo.png"
  },
  {
    tagName: "div",
    backColor: "rgb(257,77,97)",
    logo: "images/bakcell.png"
  },
  {
    tagName: "div",
    backColor: "rgb(176, 4, 62)",
    logo: "images/nar.jpg"
  },
  {
    tagName: "div",
    backColor: "rgb(193, 188, 36)",
    logo: "images/AZERISHIQ_LOGO_gold-e1468303994304.png"
  },
  {
    tagName: "div",
    backColor: "rgb(223, 31, 148)",
    logo: "images/ec46dae9-e637-498d-adc5-e12034b5b34e.jpg"
  }
];
var secondArray = [
  {
    TagName: "div",
    _backColor: "rgb(23,92,179)",
    _logo: "images/communal.png",
    text: "<h1>Коммунальные платежи</h1>"
  },
  {
    TagName: "div",
    _backColor: "rgb(253,169,6)",
    _logo: "images/hand-with-smartphone-and-wireless-internet.png",
    text: "<h1>Мобильные операторы</h1>"
  },
  {
    TagName: "div",
    _backColor: "rgb(61,30,121)",
    _logo: "images/bill.png",
    text: "<h1>Банковские услуги</h1>"
  },
  {
    TagName: "div",
    _backColor: "rgb(177,29,165)",
    _logo: "images/university-with-a-flag.png",
    text: "<h1>Государство и муниципалитеты</h1>"
  },
  {
    TagName: "div",
    _backColor: "rgb(68,128,28)",
    _logo: "images/monitor.png",
    text: "<h1>TВ</h1>"
  },
  {
    TagName: "div",
    _backColor: "rgb(239,58,37)",
    _logo: "images/Wifi.png",
    text: "<h1>Интернет</h1>"
  },
  {
    TagName: "div",
    _backColor: "rgb(49,137,188)",
    _logo: "images/old-telephone-ringing.png",
    text: "<h1>Tелефон</h1>"
  },
  {
    TagName: "div",
    _backColor: "rgb(179,30,69)",
    _logo: "images/gamepad.png",
    text: "<h1>Развлечения и игры</h1>"
  },
  {
    TagName: "div",
    _backColor: "rgb(180,116,48)",
    _logo: "images/wallet-filled-money-tool.png",
    text: "<h1>E-кошелек</h1>"
  }
];
var k = 1;
var $width = secondWidth / 3;
function init() {
  var azeri = document.createElement("img");
  azeri.src = "images/Socar_logo.png";
  var mainlogo = document.createElement("img");
  var secondlogo = document.createElement("img");
  var az_icon = document.createElement("img");
  var en_icon = document.createElement("img");
  var ru_icon = document.createElement("img");
  ru_icon.src = "images/if_Flag_of_Russia_96241.png";
  ru_icon.className = "ru_icon";
  ru_icon.onclick = ChangeToRusssian;
  en_icon.src = "images/if_Flag_of_United_Kingdom_96354.png";
  en_icon.className = "en_icon";
  en_icon.onclick = ChangeToEnglish;
  az_icon.src = "images/if_Flag_of_Azerbaijan_96205.png";
  az_icon.className = "az_icon";
  az_icon.onclick = ChangeToAzerbaijani;
  secondlogo.className = "secondlogo";
  secondlogo.src = "images/Info-I-Logo.png";
  mainlogo.className = "mainlogo";
  mainlogo.src = "images/emanat.png";
  var imgarray = [az_icon, ru_icon, en_icon];
  var mainparent = document.createElement("div");
  var langConfig= document.createElement("div");
  langConfig.className="langConfig";
  mainparent.className="firstParent";
  var container = document.createElement("div");
  container.className="container";
  for (var elem of imgarray) {
    langConfig.appendChild(elem);
  }
  mainparent.appendChild(mainlogo);
  mainparent.appendChild(secondlogo);
  document.body.appendChild(container);
  container.appendChild(mainparent);
  container.appendChild(langConfig);
  var parent = createElement("div", mainWidth, document.body, "parent", null);
  var width = mainWidth / arry.length;
  for (var element of arry) {
    var child = createElement(
      element.tagName,
      width,
      parent,
      "child",
      element.backColor,
      null
    );
    parent.appendChild(child);
    for (var logos in arry) {
      var $logo = document.createElement("img");
      $logo.src = element.logo;
      $logo.className = "logo";
      child.appendChild($logo);
      break;
    }
  }
  var secondParent = document.createElement("div");
  secondParent.className = "secondparent";
  document.body.appendChild(secondParent);
  var k = 0;
  for (var sec_element of secondArray) {
    var secondChild = createElement(
      sec_element.TagName,
      $width,
      secondParent,
      "secondchild",
      sec_element._backColor,
      "secondchild" + k
    );
    for (var _logo of secondArray) {
      var $logos = document.createElement("img");
      var logoblock = document.createElement("div");
      $logos.src = sec_element._logo;
      // $logos.id=
      $logos.className = "secondlogo";
      logoblock.className = "logoblock";
      logoblock.appendChild($logos);
      secondChild.appendChild(logoblock);
      break;
    }
    secondParent.appendChild(secondChild);
    for (var text of secondArray) {
      var txt = document.createElement("div");
      txt.className = "textblock";
      txt.innerHTML = sec_element.text;
      secondChild.appendChild(txt);
      break;
    }
    k++;
  }
  document.getElementById("secondchild0").onclick = () => {
    localStorage.setItem("base", "kommunal");
    document.location.href = "provider.html";
  };
  document.getElementById("secondchild1").onclick = () => {
    localStorage.setItem("base", "mobile");
    document.location.href = "provider.html";
  };
  document.getElementById("secondchild2").onclick = () => {
    localStorage.setItem("base", "bank");
    document.location.href = "provider.html";
  };
  document.getElementById("secondchild3").onclick = () => {
    localStorage.setItem("base", "country");
    document.location.href = "provider.html";
  };
  document.getElementById("secondchild4").onclick = () => {
    localStorage.setItem("base", "tv");
    document.location.href = "provider.html";
  };
  document.getElementById("secondchild5").onclick = () => {
    localStorage.setItem("base", "internet");
    document.location.href = "provider.html";
  };
  document.getElementById("secondchild6").onclick = () => {
    localStorage.setItem("base", "telefon");
    document.location.href = "provider.html";
  };
  document.getElementById("secondchild7").onclick = () => {
    localStorage.setItem("base", "fun");
    document.location.href = "provider.html";
  };
  document.getElementById("secondchild8").onclick = () => {
    localStorage.setItem("base", "wallet");
    document.location.href = "provider.html";
  };
  var footer = document.createElement("div");
  footer.className = "footer";
  footer.innerHTML = "Служба поддержки клиентов: 012 404 48 88";
  document.body.appendChild(footer);
}
function createElement(_tagName, _width, _parent, _className, background, _id) {
  var element = document.createElement(_tagName);
  element.style.width = _width + "px";
  element.className = _className;
  element.id = _id;
  element.style.background = background;
  _parent.appendChild(element);
  return element;
}
function ChangeToRusssian() {
  var elems = document.body.children;
  for (var e of elems) {
    e.remove();
  }
  for (var e of elems) {
    e.remove();
  }

  for (var e of elems) {
    e.remove();
  }
  for (var e of elems) {
    e.remove();
  }
  var russian = document.createElement("script");
  russian.src = "js/lang/ru.js";

  document.body.appendChild(russian);
}
function ChangeToEnglish() {
  var elems = document.body.children;

  for (var e of elems) {
    e.remove();
  }
  for (var e of elems) {
    e.remove();
  }

  for (var e of elems) {
    e.remove();
  }
  for (var e of elems) {
    e.remove();
  }
  var english = document.createElement("script");
  english.src = "js/lang/en.js";

  document.body.appendChild(english);
}
function ChangeToAzerbaijani() {
  var elems = document.body.children;

  for (var e of elems) {
    e.remove();
  }
  for (var e of elems) {
    e.remove();
  }

  for (var e of elems) {
    e.remove();
  }
  for (var e of elems) {
    e.remove();
  }
  var azerbaijani = document.createElement("script");
  azerbaijani.src = "js/lang/az.js";

  document.body.appendChild(azerbaijani);
}
init();
