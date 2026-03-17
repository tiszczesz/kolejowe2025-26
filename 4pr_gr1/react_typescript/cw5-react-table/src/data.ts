export type User = {
  id: number;
  name: string;
  email: string;
  role: "admin" | "user"| "guest";
};
export const users: User[] = [  
    { id: 1, name: "Jan Kowalski", email: "jan.kowalski@example.com", role: "admin" },
    { id: 2, name: "Anna Nowak", email: "anna.nowak@example.com", role: "user" },
    { id: 3, name: "Piotr Wiśniewski", email: "piotr.wisniewski@example.com", role: "guest" },
  { id: 4, name: "Katarzyna Zielińska", email: "katarzyna.zielinska@example.com", role: "user" },
  { id: 5, name: "Marek Lewandowski", email: "marek.lewandowski@example.com", role: "guest" },
  { id: 6, name: "Alicja Kamińska", email: "alicja.kaminska@example.com", role: "admin" },
    
];