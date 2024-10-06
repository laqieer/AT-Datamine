-- このluaスクリプトは、CO_101064_0602.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_005)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Joy")
	change_face(Actor001,"Smile")

	--★★ノワール★★:実は、蕾がついたんだよ<br>あのハーブ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020002")

	change_face(Actor002,"Smile")

	--★★リアム★★:それは大変素晴らしい<br>頑張りましたね、ノワールさん
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:希少な品種なんだろう？<br>これまで以上に丁寧に栽培しないとなと思ってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020005")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:注意点があったら教えてほしいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020006")

	change_face(Actor002,"Normal")

	--★★リアム★★:ふむ…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020007")


	--★★リアム★★:真面目で熱心な方だとは思っていましたが<br>予想以上だったようです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020009")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020010")


	--★★リアム★★:あのハーブは毎日細やかに<br>世話をしてあげることが重要です
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020011")


	--★★リアム★★:蕾を付けさせることは枯らさないようにするより<br>難しいとすら言われているのですよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020012")


	--★★ノワール★★:え、そうなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★リアム★★:はい。名人と呼ばれる方が<br>「最後はハーブの気分次第」と仰るくらいです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020014")

	open_select_window_tag(Actor001,"Normal","CO_101064_06020016","CO_101064_06020017")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:へえ…！なんだか嬉しいな<br>ハーブ栽培、楽しくなってきたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020019")

	change_face(Actor001,"Normal")

	--★★ノワール★★:あのハーブを部屋に置いてからは<br>毎朝起きるのが気持ちいいしさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★リアム★★:大変結構。なにごとも楽しくやることが<br>上達の第一歩です
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020021")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★リアム★★:私としても<br>勧めた甲斐があるというものです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020022")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:もしかして…俺ってすごい？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020024")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★リアム★★:ハーブ栽培において<br>類まれな才能をおもちなのかもしれませんね
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020025")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…ひょっとして、少し妬んでる？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020026")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Normal")

	--★★リアム★★:そんなことはありません
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020027")

	change_face(Actor001,"Normal")

	--★★ノワール★★:本当に？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★リアム★★:本当です
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020029")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:蕾が付いたってことは<br>順調にいけば花が咲くってことだよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020031")

	change_face(Actor001,"Smile")

	--★★ノワール★★:どんな花なんだろう<br>楽しみだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020032")

	change_face(Actor002,"Smile")

	--★★リアム★★:ふふっ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020034")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ん？<br>リアムさん今笑ったか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020035")

	change_face(Actor002,"Normal")

	--★★リアム★★:失礼、つい
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020036")

	PlayAction(Actor002,"to  Std_Talk")

	--★★リアム★★:開花を楽しみにする貴方を見て<br>昔の自分を思い出しました
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020037")


	--★★ノワール★★:昔のリアムさん…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020038")


	--★★リアム★★:あのハーブの栽培には<br>私も最初苦労しました
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020039")


	--★★リアム★★:何度も失敗し<br>そのたびに先生のやり方をまねて
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020040")

	change_face(Actor002,"Smile")

	--★★リアム★★:初めて花が咲きそうだとなったときは<br>ガラにもなく大はしゃぎしたものです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020041")


	--★★ノワール★★:先生…？<br>リアムさんにもハーブの先生がいたのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020042")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★リアム★★:ええ、以前少し話したでしょう<br>私の性根を叩き直してくれた方ですよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020043")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:へぇ…けど、性根を叩き直すことと<br>ハーブの栽培にどういう関係が？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020044")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★リアム★★:お恥ずかしい話ですが…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020046")

	change_face(Actor002,"Normal")

	--★★リアム★★:私は昔、ある大きな町の有力者の息子に<br>喧嘩を売って追われる身となっていました
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020047")


	--★★リアム★★:そんなときに偶然、ひとりの司祭に出会い<br>教会に匿ってもらっていたのです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020048")


	--★★ノワール★★:本当にヤンチャしてたんだな…<br>じゃあ、そのときにハーブの栽培を？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020049")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★リアム★★:ええ。教会の一室をお借りする代わりに<br>ハーブの世話を手伝うことになりました
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020050")


	--★★リアム★★:初めはこんな老人でもできるのだから<br>簡単だと思っていたのですが
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020051")

	change_face(Actor002,"Sad")

	--★★リアム★★:さっぱりうまくいかず次々と枯らしてしまい<br>非常に悔しい思いをしました
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020052")

	change_face(Actor001,"Normal")

	--★★ノワール★★:それでいろいろ勉強したのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020053")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★リアム★★:はい。先生のやりかたを盗み見たり<br>本を読んだり、試行錯誤を重ねました
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020054")


	--★★リアム★★:そうこうしているうちに、教会で育てた植物を<br>子供たちにプレゼントする機会がありましてね
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020055")


	--★★リアム★★:そこに私が育てた植物も含まれていました
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020056")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:それはいいイベントだな<br>子供たちも喜んでくれたんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020057")

	change_face(Actor002,"Smile")

	--★★リアム★★:ええ、とても
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020059")


	--★★リアム★★:こんな私でも誰かを笑顔にすることができる<br>そのことをとても嬉しく感じました
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020060")

	change_face(Actor002,"Normal")

	--★★リアム★★:そして、同時に思ったのです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020061")


	--★★リアム★★:もしかすると私にも<br>別の生きかたがあるのかもしれない、と
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020062")


	--★★リアム★★:今思えば、先生はそのことを学ばせるために<br>私にハーブの世話を手伝わせたのかもしれません
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020063")

	open_select_window_tag(Actor001,"Normal","CO_101064_06020065","CO_101064_06020066")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	change_face(Actor001,"Smile")

	--★★ノワール★★:いい先生だったんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020068")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★リアム★★:そうですね、いい先生でした
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020069")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★リアム★★:ハーブの栽培以外にも<br>さまざまなことを教えてもらいましたよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020070")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、それはさすがに考えすぎというか<br>ただの偶然じゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020072")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★リアム★★:そうかもしれませんね<br>しかし、それでも構いません
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020073")

	change_face(Actor002,"Normal")

	--★★リアム★★:偶然であろうとなかろうと<br>大切なことを学べたのは事実ですから
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020074")

	goto Block2end

::Block2end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:その先生は今どこに？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020076")

	change_face(Actor002,"Sad")

	--★★リアム★★:１０年ほど前にとある事故…<br>いえ、事件に巻き込まれて他界されました
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020077")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Normal")

	--★★リアム★★:「大したことはできなかったが<br>周りの多くの人間に癒しを届けられた」
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020078")


	--★★リアム★★:「誇らしい一生だった」<br>そう言い残してね
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020079")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ごめん<br>余計なことを聞いてしまって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_06020080")

	change_face(Actor002,"Smile")

	--★★リアム★★:いいえ、構いませんよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020081")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★リアム★★:――まったく。最期まで<br>人間とハーブが同じである必要はないのに…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_06020083")

-- ▼直接出力
local trustParam = set_communication_rankup("リアム_コミュランク", "リアム_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110101)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
