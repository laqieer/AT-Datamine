-- このluaスクリプトは、CO_101039_0602.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114011_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_006)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	template1()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.7,0.6)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.7,0.6)
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ローラ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ローラ★★:ここまでで大丈夫だよ<br>見送りありがとう、ふたりとも
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_06020002")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Sad")

	--★★フレン★★:忘れ物はない？<br>チケットは持った？ハンカチは？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06020004")

-- ▼直接出力
PlayPartVoice("ローラ", "笑い")
-- ▲直接出力

	--★★ローラ★★:もう、本当に心配性なんだから<br>お姉ちゃんにそんな顔は似合わないよ
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_06020005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ローラ★★:私が好きなのは<br>いつもみんなと楽しく笑ってるお姉ちゃん
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_06020006")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ローラ★★:学園で待ってて<br>すぐに戻ってくるから
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_06020007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:うん
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06020008")

-- ▼直接出力
PlayPartVoice("ローラ", "挨拶")
-- ▲直接出力

	--★★ローラ★★:ノワールさん<br>お姉ちゃんをよろしくお願いします
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_06020009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101039_06020011","CO_101039_06020012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、任された
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_06020014")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ローラのいないあいだは<br>俺がフレンを元気づけておく
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_06020015")

-- ▼直接出力
PlayPartVoice("ローラ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ローラ★★:ありがとう<br>ノワールさんがいれば安心だね
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_06020016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:わかった<br>その代わり、ローマのお土産よろしくな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_06020018")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フレン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:あっ！お土産だったら私<br>小鳥を模したアクセサリーがいいな
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06020019")

	change_face(Actor003,"Surprise")

	--★★ローラ★★:もう、お姉ちゃん<br>さっきは泣きべそかいてたくせに
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_06020020")

-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:えへへ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06020021")

	goto Block1end

::Block1end::
-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera003)
end
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
	change_face(Actor003,"Smile")

	--★★ローラ★★:それじゃ、行ってくるね
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_06020023")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor003)
setup_small_camera_start()
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:いつもみんなと楽しく笑ってる私、か
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06020025")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フレン★★:よーし！今日は陸上部に顔を出そう<br>ノワールくんも付き合ってくれるよね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_06020026")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:陸上部か<br>ずいぶん久々な気がするな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_06020027")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:大会の話がどうなったかも気になるし<br>うん、俺も付き合うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_06020028")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_フレン_ランクアップ6_3")
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
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
