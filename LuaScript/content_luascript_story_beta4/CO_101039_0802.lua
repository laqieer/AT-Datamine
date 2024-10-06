-- このluaスクリプトは、CO_101039_0802.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_04","110071_04_h")
Include("content_adv_advsmall_110071_04","Template110071_04_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_005)
	InitializeTemplateRandomCamera110071_04()
	InitializeTemplate110071_04()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_weight(Actor002,0.45,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003,Actor002,"J_Head")
lookat_weight(Actor003,0.45,0.1,0.8,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor003,"Surprise")

	--★★ローラ★★:あれ？<br>お姉ちゃん、今日は練習じゃなかったの？
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_08020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:まだ時間があるから<br>ノワールくんとお見送りに来ちゃった
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08020003")

-- ▼直接出力
PlayPartVoice("ローラ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ローラ★★:そっか<br>ふふ、ありがとう
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_08020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ローラ★★:ふたりとも<br>競技大会の件、頑張ってね
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_08020005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101039_08020007","CO_101039_08020008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そのことなら心配はいらないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08020010")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺たちのことは気にせず<br>ローラは自分のことに集中してくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08020011")

-- ▼直接出力
PlayPartVoice("ローラ", "悩む")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ローラ★★:えっ？う、うん…
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_08020012")

	change_face(Actor002,"Normal")

	--★★フレン★★:…
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08020014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08020016")

	change_face(Actor001,"Normal")

	--★★ノワール★★:フレンとふたりでケンカを仲裁して<br>必ず競技大会を開催してみせるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08020017")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ローラ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ローラ★★:ふたりなら絶対にできるよ<br>私、応援してるから
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_08020018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:ローラの応援があれば百人力だね！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08020019")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そうだ、ローラ<br>俺たちの応援だけじゃなくてさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08020020")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:競技大会に顔を出してさ<br>参加するみんなも応援してやってくれよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08020021")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フレン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:それいいね！<br>ローラが好きって子、たくさんいるし
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08020022")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ローラ", "照れ")
-- ▲直接出力
	change_face(Actor003,"Shy")

	--★★ローラ★★:えっ！？<br>そ、そうなんだ…嬉しいな…
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_08020024")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ローラ", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ローラ★★:あっ！<br>私、そろそろ行かないと
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_08020026")

-- ▼直接出力
PlayPartVoice("ローラ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ローラ★★:もうひと頑張りしなくちゃ<br>ローマとログレスのみんなのために
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_08020027")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera002)
end
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:行ってらっしゃい！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08020028")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor003)
setup_small_camera_start()
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.8)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:ローマとログレスのみんなのために、かあ<br>ローラ、頑張ってるね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08020030")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フレン★★:よーし、私も負けてらんない<br>なんとしてでも競技大会を開催しなきゃ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08020031")

-- ▼直接出力
wait_time(0.4)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
wait_time(0.4)
-- ▲直接出力

	--★★フレン★★:ノワールくん、練習場に行って<br>みんなの話を聞いてみよう！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08020032")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_フレン_ランクアップ8_3")
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
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
