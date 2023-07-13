/*Random core*/

let Canvas=document.getElementById("stats").getContext("2d");
var chart = new Chart(Canvas,{
    type:"line",
    data:{
        datasets:[
            {
                label: 'Acciones',
                data: [59, 80, 81, 56, 55, 40],
                fill: true,
                tension:0,
                borderColor: 'rgb(250, 100, 0)',
                backgroundColor: '#01548f',
                pointBackgroundColor: '#01548f'
            }
        ]
    }
})