-- このluaスクリプトは、CO_101012_0402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",70,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
Hide(Actor003)
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {0.5, 0.2, 0.8, 0.6} , 1) 
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:実はね、この間の手紙の件で…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04020002")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:手紙…ラブレターか<br>あれだったら全員に断りの返事をしたんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_04020003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:うん。そうなの<br>みんなわかってくれたと思ったんだけど
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:でも、手紙をくれたうちのひとりから<br>「せめて1回だけデートして！」って言われて…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04020005")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力

	--★★ディナタン★★:それで、私断れなくって…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04020006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101012_04020008","CO_101012_04020009","CO_101012_04020010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:優しいディナタンらしいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_04020012")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:優しいとかじゃないよ<br>ほんとは、ちゃんと断るべきなのに
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04020013")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:けど、その人を傷つけたくないって<br>思っちゃったんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_04020014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ディナタン★★:………うん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04020015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:俺が代わりに断ってやろうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_04020017")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:だ、だめだよ！そんなの<br>そんなことしたら、失礼だもん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04020018")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:それに…兄さんの印象も悪くなっちゃう<br>そんなの嫌だから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04020019")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:すでにフラれたくせにデートに誘うとか<br>図々しい奴だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_04020021")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:ちょっと、兄さん！<br>そんなこと言わないで
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04020022")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:この人は悪くないよ<br>悪いのはちゃんと断れなかった私なの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04020023")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…で、これからそいつとデートってわけか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_04020025")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ディナタン★★:うん…ここで待ち合わせしてて<br>もう少ししたら来る予定なんだけど
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04020026")


	--★★ディナタン★★:私、兄さんとランス兄ちゃん以外の男の人と<br>ふたりきりなんて初めてで…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04020027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力

	--★★ディナタン★★:どうしたらいいかわからなくて…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04020029")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:なら、俺が見ててやるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_04020030")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:え！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04020031")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:近くに俺がいれば、ディナタンも安心だろ<br>どうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_04020032")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…うん、そうしてくれると嬉しい
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04020033")

-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:兄さんが近くで見守ってくれてれば<br>なんとか頑張れそう
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04020034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to Greet_one")

	--★★ノワール★★:それじゃ、俺はすぐ近くに隠れてるから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_04020035")

-- ▼直接出力

 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor001)
Appear(Actor003)
set_enable_auto_lookat(Actor003,false)
lookat_delay_weight(Actor003, {0.4, 0.08, 0.7, 0.6} , 1)
keep_ik_lookat(Actor003,Actor002,"J_Head")
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight(Actor002, {0.4, 0.08, 0.7, 0.6} , 1)
keep_ik_lookat(Actor002,Actor003,"J_Head")
--フェードイン
 setup_small_camera_start()
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:ウィルくん…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04020037")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:お待たせ<br>それじゃ、さっそく行こうか
	Talk(Actor003,"NPCNAME_0239","speech","L","CO_101012_04020038")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:う、うん…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_04020039")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ディナタン_ランクアップ4_3")
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
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
MobsNo = 0
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
