-- このluaスクリプトは、CO_101032_0703.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114021_01","114021_01_h")
Include("content_adv_advsmall_114021_01","Template114021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",144,CharaPos114021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_002)
	Camera003 = SetTemplate("Actor003",235,CharaPos114021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_007)
	InitializeTemplateRandomCamera114021_01()
	InitializeTemplate114021_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.55,0.2,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガレス", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:…釣れなかった……もはや存在しなのではと思えるくらい…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030002")


	--★★ガレス★★:やっぱり、無理なのかな…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030004")


	--★★ガレス★★:無理してるのかな、わたし…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ガレス", "悲しみ")
-- ▲直接出力

	--★★ガレス★★:ランスロットとケイの前では強がってみせたけどときどき弱気になっちゃうことがあるんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030007")


	--★★ガレス★★:わたしが料理を始めたのは兄さんのためなんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030008")

	change_face(Actor002,"Normal")

	--★★ガレス★★:兄さんはさ生まれてすぐに家を出されたんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030009")


	--★★ガレス★★:父さんはいつも戦争に行ってたし他のきょうだいもいつも訓練ばっかりで
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030010")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:わたしの家の食卓は家族が勢揃いしたことがなかったんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030012")

	change_face(Actor002,"Normal")

	--★★ガレス★★:母さんといつも言ってた
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガレス★★:「ガウェイン兄さんろくなご飯を食べられてないんじゃないかな？」
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030014")


	--★★ガレス★★:「いつか兄さんに笑顔と食卓を届けてあげたいね」って
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "悩む")
-- ▲直接出力

	--★★ガレス★★:母さんと考えたんだ。そのときが来たとして兄さんが一番喜んでくれるのはなんだろうって
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガレス★★:それで、料理を勉強した心のこもった手料理に勝るものはないからね
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030018")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ガレス", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★ガレス★★:でも、兄さんがいなくなった今わたしはなんで料理してるんだろう？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101032_07030021","CO_101032_07030022","CO_101032_07030023")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガウェインは必ず戻ってくるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_07030025")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:言ってたじゃないか<br>ガレスの料理を楽しみにしてるって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_07030026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ガレス★★:うん…<br>言ってたね…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030027")

-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:うん、たしかに兄さんは言ってたヒーローは約束を破らないよな♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030028")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ガレス無理はしないほうがいい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_07030030")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ランスロットとケイも言ってたろ？無理ならすぐに休めって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_07030031")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:あっ、う、うそうそ！<br>さっきのは冗談だよ♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030032")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ガレス★★:わたしなら元気！バルバロイでもなんでもかかってこい！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030033")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺はガレスの料理が大好きだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_07030035")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺だけじゃない<br>学園のみんな、ガレスの料理が大好きだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_07030036")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:それは料理をする理由にならないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_07030037")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ガレス★★:ノワール、ありがとう…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030038")

-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:みんながわたしの料理を待ってくれてるすごく大事な理由だよね
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030039")

-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:料理人が匙を投げちゃダメだよね♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030040")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ガレス★★:ナイトカジキのことは残念だけど似た食材があるかもしれない。探してみよう
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030042")

-- ▼直接出力
PlayPartVoice("ガレス", "納得")
-- ▲直接出力

	--★★ガレス★★:ノワール、リオネス、今日は帰ろう
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030044")


	--★★リオネス★★:…イヤだ<br>あたしは帰らない
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_07030045")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
lookat_delay_weight(Actor002,0.5,0.2,0.8,0.2,1.0)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガレス★★:リオネス？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030046")

-- ▼直接出力
PlayPartVoice("リオネス", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★リオネス★★:ナイトカジキを釣るまであたしは帰らない
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_07030047")

-- ▼直接出力
PlayPartVoice("ガレス", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:今日はもう遅いしきっと他に美味しい魚もあるよ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030049")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "否定")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★リオネス★★:イヤだ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_07030050")


	--★★リオネス★★:ガレスはあたしを笑顔の食卓に招待してくれた！ガレスはあたしの大事な家族なんだ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_07030051")


	--★★リオネス★★:ガレスの悲しい顔は見たくない！あたしは家族のやりたいことを応援したい！！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_07030052")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガレス", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:リ…オネス…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07030053")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:お、おい、リオネス！竿！竿！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_07030055")

-- ▼直接出力
PlayPartVoice("リオネス", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★リオネス★★:え？うわあ、なんだこれ！？すごい引きだぞ！ノワール手伝ってくれ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_07030056")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:わ、わかった！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_07030057")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ガレス_ランクアップ7_4")
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
	load_area_scene_preload(114021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
