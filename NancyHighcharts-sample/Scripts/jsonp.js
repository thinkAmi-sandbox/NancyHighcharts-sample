$(function () {
    var chart = new Highcharts.Chart({
        chart: {
            renderTo: 'container',
            defaultSeriesType: 'pie',
        },

        title: {
            text: '食べたリンゴたち JSONP ver'
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

    $.getJSON('https://ringo-tabetter.herokuapp.com/api/jsonp/total?callback=?', function (res) {
        $.each(res, function (i, json) {
            chart.series[0].addPoint({
                name: json['name'],
                y: json['amount'],
                color: json['color']
            });
        });
    });
});