-- このluaスクリプトは、CO_101011_0102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110041_02","110041_02_h")
Include("content_adv_advsmall_110041_02","Template110041_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110041_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110041_02,CameraPos110041_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110041_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110041_02,CameraPos110041_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110041_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110041_02,CameraPos110041_02_003)
	InitializeTemplateRandomCamera110041_02()
	InitializeTemplate110041_02()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…屋上でパーッと遊ぶのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_01020002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:今日は気分転換よ<br>ひとまずね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020003")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera005)
-- ▲直接出力
-- ▼直接出力
wait_time(3.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,135.3,0.5)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:わざわざ話しかけてきたのは<br>遊びの誘いだけじゃないだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_01020005")

-- ▼直接出力
setup_small_camera_start()
keep_ik_lookat(Actor002,Actor001,"J_Head")
keep_ik_lookat(Actor001,Actor002,"J_Head")
turn_lookat(Actor002,Actor001,0.5)
turn_chara(Actor003,14.501,0.5)
PlayActionDirect(Actor002,"to Wlk")
PlayActionDirect(Actor003,"to Wlk")
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:さすが<br>お見通しだったってわけね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020006")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:…あらためて<br>お礼を言っておこうと思って
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020007")


	--★★ノワール★★:お礼？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_01020008")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:キャメリアードでの戦いのこと
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020009")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:あのとき励ましてくれてありがと<br>…嬉しかった
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101011_01020012","CO_101011_01020013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺はなにも大したことしてないよ<br>キミが頑張ったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_01020015")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ふふ<br>気を使ってくれてるんだ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020016")

	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:やさしいね、ノワールは
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…そんなことあったっけ？<br>キミが頑張ってたことは覚えてるけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_01020019")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:ウソ、忘れちゃってるの！？<br>信じらんない！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:…気を使ってくれたんだよね<br>ありがと
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020021")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:あのね<br>わたし、考えたの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020023")


	--★★ギネヴィア★★:あのときノワールの励ましがあったから<br>わたしは後悔せずに済んだ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:パパを救ってあげることができた
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:じゃあ、今度はわたしがノワールを<br>元気づけてあげる番なんじゃないかなって
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101011_01020028","CO_101011_01020029","CO_101011_01020030")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ありがとう<br>せっかくだし、お願いしようかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_01020032")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:わたしにま～かせて！<br>このへんで遊べる場所、詳しいんだから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020033")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "落胆")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:あまり自慢できることでは<br>ないような気もしますけれどね
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_01020034")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そこまで気にしてもらわなくても<br>いつも元気をもらってるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_01020036")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:違うのよ<br>今は学園でちょっと話すくらいでしょ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020037")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:これからはふたりで話す時間を作って<br>なんでも相談に乗ったげる
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020038")

	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:あっ！<br>なんでもっていっても、限度はあるわよ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020039")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:たとえばその…<br>い、いやらしい話とかはＮＧだから！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020040")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:しないよ、そんな相談
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_01020041")

-- ▼直接出力
PlayPartVoice("ギネマウア", "落胆")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:羽目を外し過ぎないように<br>しばらくは私もおともします
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_01020042")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今は間に合ってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_01020044")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:こ、この流れで<br>その返しは予想してなかったわ…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020045")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "落胆")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:やっかいなお相手のようですね
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_01020046")

	goto Block2end

::Block2end::
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:とにかく、もう決めたの<br>決めたの、わたし
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020048")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ノワールといろんな場所に行って<br>ノワールをいっぱい元気にしてあげるの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020049")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:体よく<br>遊びの口実に使われるわけじゃないよな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_01020050")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:可能性がゼロとは<br>言い切れませんね
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_01020051")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:文句言わずに<br>付き合いなさい、わたしに
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020052")

	change_face(Actor001,"Sad")

	--★★ノワール★★:なんで命令口調なんだ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_01020053")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まあ、時間があるときに<br>少し遊びに行くくらいならいいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_01020054")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:決まりね<br>じゃ、時間があるときに声かけるから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_01020055")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？<br>いや、俺の時間があるときって意味で…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_01020056")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor002)
Hide(Actor003)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:聞いてないし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_01020058")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:仕方ない<br>付き合ってやるか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_01020060")

-- ▼直接出力
local trustParam = set_communication_acquired("ギネヴィア_コミュランク", "ギネヴィア_親密度")
-- ▲直接出力
-- ▼直接出力
open_trust_release(Actor002, trustParam)
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
	load_area_scene_preload(110041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110041_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
