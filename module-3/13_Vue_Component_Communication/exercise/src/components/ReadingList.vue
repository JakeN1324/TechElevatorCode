<template>
  <div class="book-container">
    <div class="card" v-bind:key="book.isbn" v-for="book in books">
      
    </div>
  </div>
</template>

<script>
import BookCard from './BookCard.vue'

export default {
    name: 'reading-list',
    computed: {
      books() {
        return this.$store.state.books
      }
    } 
}

        BookCard</script>

<style>
.book-container {
    display:flex;
    justify-content: space-evenly;
    flex-wrap: wrap;
}
</style>