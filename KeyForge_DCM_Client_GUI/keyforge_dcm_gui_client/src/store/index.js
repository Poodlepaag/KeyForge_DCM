import { createStore } from 'vuex'

export default createStore({
  state: {
    decks: {
      deckId: 0,
      deckName: ''
    },
    
    cards: {
      deckId: 0,
      cardId: 0,
      cardName: '',
      cardType: '',
      cardText: '',
      deck: []
    },

    searches: '',
  },
  mutations: {
    setDecks(state, data){
      state.decks = data
    },
    setCards(state, data){
      state.cards = data
    },
    setSearches(state, data){
      state.searches = data
    }
  },
  actions: {
    async fetchDecks({commit}){
      let response = await fetch('api/Decks/')
      let data = await response.json()
      console.log(data)
      commit('setDecks', data)
    },
    async fetchCards({commit}){
      let response = await fetch('api/Cards/')
      let data = await response.json()
      console.log(data)
      commit('setCards', data)
    }
  },
  modules: {
  }
})
