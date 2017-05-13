$(document).ready(function(e){
    			 // var newsNum = $(".newsticker li").size();
    			var newsNum = $(".newsticker li").length;
    			// console.log(newsNum);

    			var totalnewswidth = 0;
    			//Calculating the width of the element by looping each li	
    			for(var i=0; i<newsNum; i++){
    				var news_width = $(".newsticker li").eq(i).outerWidth(true);
    				totalnewswidth =totalnewswidth + news_width;
    				// totalnewswidth += news_width;
    			}

    			// console.log(totalnewswidth);
    			//applying the full width to ul class
    			$(".newsticker").css('width', totalnewswidth+'px');

    			var speed=1;
    			animatenews();

    			//animating the li
    			function animatenews(){
    				$(".newsticker li").eq(0).animate({
    					'marginLeft' : '-='+speed+'px'
    				},1, function(){

    					//calculating the width if li's
    					var animnewswidth = $(this).outerWidth(true);

    					if(speed >= animnewswidth){
    						$(this).parent().append($(this));
    						$(this).removeAttr('style');
    					}

    					animinterval = setTimeout(function(){
    						animatenews();
    					});
    				});
    			}

    			$(".newsticker").hover(function() {
    				/* Stuff to do when the mouse enters the element */
    				clearTimeout(animinterval);
    				$('.newsticker li').eq(0).stop();
    			}, function() {
    				/* Stuff to do when the mouse leaves the element */
    				animatenews();
    			});

    		});