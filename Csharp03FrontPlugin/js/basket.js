let basketSale=document.getElementById("baketCountType");
let table=document.getElementById("table");
let newArray=JSON.parse(localStorage.getItem("basket")); //locats-de datami goturdum

function addBasketDetail(){
    basketSale.innerText=(JSON.parse(localStorage.getItem("basket"))).length;
}
addBasketDetail();
newArray.forEach(element => {
    let tr=document.createElement("tr");
    let tdImage=document.createElement("td");
    let img=document.createElement("img");
    img.setAttribute("src",element.src);
    tdImage.append(img);


    let tdName=document.createElement("td");
    tdName.innerText=element.name;

    let tdPrice=document.createElement("td");
    tdPrice.innerText=element.price;

    let tdPrivate=document.createElement("input");
    tdPrivate.setAttribute("type","hidden");
    tdPrivate.setAttribute("value",`${element.id}`);

    let tdCount=document.createElement("td");
    tdCount.innerText=element.count;

    let totalPrice=document.createElement("td");
    totalPrice.innerText=(parseInt(tdCount.innerText)*parseInt(tdPrice.innerText))+" azn";
    let tdRemove=document.createElement("td");
    tdRemove.innerHTML="<i class=\"fas fa-trash\"></i>"
    tdRemove.onclick=function(e){
        const deleted=e.target.parentElement.getAtribute("data-id");
        delete(deleted)
        addBasketDetail()
        location.reload()
    }
    tr.append(tdImage,tdName,tdCount,tdPrice,totalPrice,tdRemove);
    table.lastElementChild.append(tr);
});