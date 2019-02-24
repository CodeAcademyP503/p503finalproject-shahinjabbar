{
    {
    var mainwidth = 1200;
    let mainarray = [
    {
        tagname:"div",
        backcolor:"black",
        image:"images/etopazLogo.png",
        text:""
    },
    {
        tagname:"div",
        backcolor:"black",
        image:"images/b4-loqo.png",
        text:""
    },
    {
        tagname:"div",
        backcolor:"black",
        image:"images/gbIndex.png",
        text:""
    }
    ,{
        tagname:"div",
        backcolor:"black",
        image:"images/azerlotereya_logo_ru.png",
        text:""
    }
    ];
    
    var Width = mainwidth/5;
    
    function init7 () {
        var header = document.createElement("h1");
        header.innerHTML = "TELEFON";
        header.className = "header";
        var parent = createElement("div", mainwidth, document.body, "mainparent", null);
        var headerInfo = document.createElement("div");
        headerInfo.className = "headerInfo";
        var headerImg = document.createElement("img");
        headerImg.src = "images/old-telephone-ringing.png";
        var borderLine = document.createElement("div");
        borderLine.className = "borderLine";
        parent.appendChild(headerInfo);
        headerInfo.appendChild(headerImg);
        headerInfo.appendChild(borderLine);
        headerInfo.appendChild(header);
        var secondParent = document.createElement("div");
        secondParent.className = "secondParent";
        document.body.appendChild(secondParent);
        for (var provider of mainarray) {
            var child = createElement(provider.tagname, Width, parent, "provider", provider.backcolor);
            secondParent.appendChild(child);
            for (var pct of mainarray) {
                var providerPart = document.createElement("div");
                providerPart.className = "providerPart";
                var divlogos = document.createElement("img");
                divlogos.src = provider.image;
                divlogos.className = "providerlogo";
                providerPart.appendChild(divlogos);
                child.appendChild(providerPart);
                break;
            }
            for (var text of mainarray) {
                var texts = document.createElement("h1");
                texts.className = "providertext";
                texts.innerHTML = provider.text;
                child.appendChild(texts);
                break;
            }
        }
        var footerPart = document.createElement("div");
        footerPart.className = "footerPart";
        document.body.appendChild(footerPart);
        var homebutton = document.createElement("button");
        homebutton.className = "homebutton";
        homebutton.innerHTML = "Geri";
        footerPart.appendChild(homebutton);
        homebutton.onclick = () =>{document.location.href = 'index.html'};  
    }
    function createElement(_tagName, _width, _parent, _className, background,_id) {
        var element = document.createElement(_tagName);
        element.style.width = _width + "px";
        element.className = _className;
        element.id = _id;
        element.style.background = background;
        _parent.appendChild(element);
        return element;
    } 
    }
}
init7();