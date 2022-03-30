<template>
  <div class="main">
    <h2>Product Reviews for {{ name }}</h2>
    <p class="description">{{ description }}</p>

    <div class="well-display">
      <div class="well">
        <span class="amount">{{averageRating}}</span>
        Average Rating
      </div>

      <div class="well">
        <span class="amount"><!-- data binding goes here --></span>
        1 Star Review
      </div>

      <div class="well">
        <span class="amount"><!-- data binding goes here --></span>
        2 Star Review
      </div>

      <div class="well">
        <span class="amount"><!-- data binding goes here --></span>
        3 Star Review
      </div>

      <div class="well">
        <span class="amount"><!-- data binding goes here --></span>
        4 Star Review
      </div>

      <div class="well">
        <span class="amount"><!-- data binding goes here --></span>
        5 Star Review
      </div>
    </div>

    <div class="review" v-for="review in reviews" v-bind:key="review.reviwer">
      <h4>{{ review.reviewer }}</h4>
      <h3>{{ review.title }}</h3>
      <p>{{ review.review }}</p>
    </div>
  </div>
</template>

<script>
export default {
  name: "product-review",
  data() {
    return {
      madeupname: "John",
      name: "Cigar Parties for Dummies and .NET students",
      description:
        "Host and/or plan the perfect cigar party for all of your squirrelly friends.",
      reviews: [
        {
          reviewer: "Malcolm Gladwell",
          title: "What a book!",
          review:
            "It certainly is a book. I mean, I can see that. Pages kept together with glue and there's writing on it, in some language.",
          rating: 5,
        },
        {
          reviewer: "John Fulton",
          title: "It's a book!",
          review: "Wow!",
          rating: 3,
        },
      ],
    };
  },
  computed: {
    averageRating() {
      // Use reduce to get the total of all the ratings
      let sum = this.reviews.reduce((currentSum, review) => {
        return currentSum + review.rating;
      }, 0);

      // Divide by the number of reviews
      return sum / this.reviews.length;
    },
  },
};
</script>

<style scoped>
div.main {
  margin: 1rem 0;
}

div.main div.well-display {
  display: flex;
  justify-content: space-around;
}

div.main div.well-display div.well {
  display: inline-block;
  width: 15%;
  border: 1px black solid;
  border-radius: 6px;
  text-align: center;
  margin: 0.25rem;
}

div.main div.well-display div.well span.amount {
  color: darkslategray;
  display: block;
  font-size: 2.5rem;
}

div.main div.review {
  border: 1px black solid;
  border-radius: 6px;
  padding: 1rem;
  margin: 10px;
}

div.main div.review div.rating {
  height: 2rem;
  display: inline-block;
  vertical-align: top;
  margin: 0 0.5rem;
}

div.main div.review div.rating img {
  height: 100%;
}

div.main div.review p {
  margin: 20px;
}

div.main div.review h3 {
  display: inline-block;
}

div.main div.review h4 {
  font-size: 1rem;
}
</style>