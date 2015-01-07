Highcharts.setOptions({
    global: {
        useUTC: false
    }
});


$(function () {
    var chart = new Highcharts.Chart({
        chart: {
            renderTo: 'container',
            defaultSeriesType: 'pie',
        },

        title: {
            text: '食べたさつまいも'
        },

        tooltip: {
            formatter: function () {
                return '<b>' + this.point.name + '</b>: ' + this.point.y + '個';
            }
        },

        plotOptions: {
            pie: {
                allowPointSelect: true,
                showInLegend: true
            }
        },


        legend: {
            layout: 'vertical',
            align: 'right',
            verticalAlign: 'top',
            x: 0,
            y: 100
        },

        series: [{
            data: [
            ]
        }]
    });

    $.getJSON('api/json', function (res) {
        $.each(res, function (i, json) {
            chart.series[0].addPoint({
                name: json['name'],
                y: json['amount'],
                color: json['color']
            });
        });
    });
});