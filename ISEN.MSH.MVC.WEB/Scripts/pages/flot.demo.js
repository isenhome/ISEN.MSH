$(function () {

    var data = [["January", 10], ["February", 8], ["March", 4], ["April", 13], ["May", 17], ["June", 9]];

    $.plot("#placeholdertime", [data], {
        series: {
            bars: {
                show: true,
                barWidth: 0.6,
                align: "center"
            }
        },
        xaxis: {
            mode: "categories",
            tickLength: 0
        }
    });

    // Add the Flot version string to the footer

    $("#footer").prepend("Flot " + $.plot.version + " &ndash; ");
});

//$(function () {

//    var container = $("#placeholdertime");

//    // Determine how many data points to keep based on the placeholder's initial size;
//    // this gives us a nice high-res plot while avoiding more than one point per pixel.

//    var maximum = container.outerWidth() / 2 || 300;

//    //

//    var data = [];
//    var is = 0;
//    function getRandomData() {

//        if (data.length) {
//            data = data.slice(1);
//        }


//        while (data.length < maximum) {
//            var previous = data.length ? data[data.length - 1] : 50;
//            var y; //= previous + Math.random() * 10 - 5;
//            if (is < 10) {
//                y = 30;
//            }
//            else if (is < 20) {
//                y = 90;
//            }
//            else if (is < 30) {
//                y = 60;
//            }
//            else if (is < 40) {
//                y = 0;
//            }
//            else {
//                is = 0;
//            }
//            is = is + 1;
//            data.push(y);
//            //data.push(y < 0 ? 0 : y > 100 ? 100 : y);
//        }

//        // zip the generated y values with the x values

//        var res = [];
//        for (var i = 0; i < data.length; ++i) {
//            res.push([i, data[i]]);
//        }

//        return res;
//    }

//    //

//    series = [{
//        data: getRandomData(),

//        bars: { show: true }
//    }];

//    //

//    var plot = $.plot(container, series, {
//        grid: {
//            borderWidth: 1,
//            minBorderMargin: 20,
//            labelMargin: 10,
//            backgroundColor: {
//                colors: ["#fff", "#e4f4f4"]
//            },
//            hoverable: true,
//            mouseActiveRadius: 50,
//            margin: {
//                top: 8,
//                bottom: 20,
//                left: 20
//            },

//            markings: function (axes) {
//                var markings = [];
//                var xaxis = axes.xaxis;
//                for (var x = Math.floor(xaxis.min); x < xaxis.max; x += xaxis.tickSize * 2) {
//                    markings.push({ xaxis: { from: x, to: x + xaxis.tickSize }, color: "rgba(232, 232, 255, 0.2)" });
//                }
//                return markings;
//            }
//        },
//        yaxis: {
//            min: 0,
//            max: 110
//        },
//        legend: {
//            show: true
//        },
//        series: {
//			bars: {
//				show: true,
//				barWidth: 0.6,
//				align: "center"
//			}
//		},
//    });

//    // Create the demo X and Y axis labels

//    //var xaxisLabel = $("<div class='axisLabel xaxisLabel'></div>")
//    //	.text("")
//    //	.appendTo(container);

//    var yaxisLabel = $("<div class='axisLabel yaxisLabel'></div>")
//		.text("Response Time (ms)")
//		.appendTo(container);

//    // Since CSS transforms use the top-left corner of the label as the transform origin,
//    // we need to center the y-axis label by shifting it down by half its width.
//    // Subtract 20 to factor the chart's bottom margin into the centering.

//    yaxisLabel.css("margin-top", yaxisLabel.width() / 2 - 20);

//    // Update the random dataset at 25FPS for a smoothly-animating chart

//    setInterval(function updateRandom() {
//        series[0].data = getRandomData();
//        plot.setData(series);
//        plot.draw();
//    }, 1000);

//});
