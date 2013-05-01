  function buildStringBuilder() {
            return {
                strs: [],
                len: 0,
                append: function (str) {
                    this.strs[this.len++] = str;
                    return this;
                },
                toString: function () {
                    return this.strs.join("");
                }
            };
 