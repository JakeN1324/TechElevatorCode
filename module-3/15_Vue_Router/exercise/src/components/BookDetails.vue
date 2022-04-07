<template>
  <div>
      <book-details v-bind:book="book" />
      <!-- <router-link v-bind:to="{ name: 'book-detail', params: { isbn: book.isbn }}" /> -->
      <h2>{{book.title}}</h2>
      <h2>{{book.author}}</h2>
  </div>
</template>

<script>



export default {
    computed: {
        book() {
          return this.$store.state.books.find(
            b => b.isbn == this.$store.state.activeBook
          );
      }
    },
    created() {
        const activeBookIsbn = this.$route.params.isbn;
        this.$store.commit("SET_ACTIVE_BOOK", activeBookIsbn);
      }
}
</script>

<style>

</style>