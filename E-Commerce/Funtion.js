let uni = 0;
let lProductos = new Array();
let lCarrito = new Array();



function ProductosCreate() {
    id = 0;
    nombre = '';
    unidad = 0;
    img = '';
    precio = 0;
}
function ProductosCreate(id, nombre, unidad, img, precio) {
    this.id = id;
    this.nombre = nombre;
    this.unidad = unidad;
    this.img = img;
    this.precio = precio;
}


function AgregarProducto(producto) {
    lProductos.push(producto);
}

function AgregarCarrito(producto) {
    lCarrito.push(producto);
}



let p1 = new ProductosCreate(0, 'Fulbito de Mani', uni, "/Images/Fulbito de Mani.jpg", 70)
let p2 = new ProductosCreate(1, 'Fulbito Negro', uni, "/Images/Fulbito Negro.jpg", 50)
let p3 = new ProductosCreate(2, 'Alfajores Tofi x6', uni,"/Images/Tofi x6.jpg" , 1000)
let p4 = new ProductosCreate(3, 'Alfajor Tofi', uni, "/Images/Tofi.jpg", 250)
let p5 = new ProductosCreate(4, 'Alfajor Tatin', uni, "/Images/Tatin.jpg", 150)
AgregarProducto(p1);
AgregarProducto(p2);
AgregarProducto(p3);
AgregarProducto(p4);
AgregarProducto(p5);



let btnResultado = "";

let Total = document.getElementById("Total");
let cantidad = 0;


function AgregarAlCarrito(producto) {


    if (document.getElementsByName("resultado")[producto.id].innerHTML > 0) {
        let carrito = document.getElementsByClassName("compras")[0];
        let btnNav = document.getElementById("btnNav");

        let row = document.createElement("div");
        let col = document.createElement("div");

        let btnExit = document.createElement("button");
        btnExit.name = "btnExit";
        btnExit.type = "button";
        btnExit.classList.add("btn-close");
        btnExit.style = "float: right";



        let img = document.createElement("img");
        img.src = producto.img;
        img.style = "display: inline-block;margin-bottom: 10px;"

        let p = document.createElement("p");
        producto.uni = document.getElementsByName("resultado")[producto.id].innerHTML;
       
        p.textContent = "  Unidades: " + producto.uni + " $" + producto.uni * producto.precio
        p.style = "display: inline-block;"

        row.classList.add("row");
        col.classList.add("col");

        col.appendChild(img);
        col.appendChild(p);
        col.appendChild(btnExit);
        row.appendChild(col);
        carrito.appendChild(row);
        document.getElementsByName("resultado")[producto.id].innerHTML = 0;

        cantidad += producto.uni * producto.precio;
        btnNav.click();
        lCarrito.push(producto);
        total();

        btnExit.addEventListener('click', function () {
            row.parentNode.removeChild(row);
            cantidad -= producto.uni * producto.precio;
            total();
        });

    }

}




function total() {
    Total.innerText = "Total: $" + cantidad
}

function Sumar(id) {

    let btnMenos = document.getElementsByName("botonMenos")[id];
    let btnResultado = document.getElementsByName("resultado")[id];
    let btnMas = document.getElementsByName("botonMas")[id];

    if (btnResultado.innerText >= 0) {
        let valor = btnResultado.innerHTML;
        valor++;
        btnResultado.innerHTML = valor;
    }
}

function Restar(id) {

    let btnMenos = document.getElementsByName("botonMenos")[id];
    let btnResultado = document.getElementsByName("resultado")[id];
    let btnMas = document.getElementsByName("botonMas")[id];

    if (btnResultado.innerText > 0) {
        let valor = btnResultado.innerHTML;
        valor = valor - 1;
        btnResultado.innerHTML = valor;
    }
}
