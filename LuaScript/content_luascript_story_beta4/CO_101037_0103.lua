-- このluaスクリプトは、CO_101037_0103.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_03","110061_03_h")
Include("content_adv_advsmall_110061_03","Template110061_03_h")
Include("content_adv_advsmall_110061_02","110061_02_h")
Include("content_adv_advsmall_110061_02","Template110061_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110061_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110061_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_002)
	InitializeTemplateRandomCamera110061_03()
	InitializeTemplate110061_03()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
prop001 = setup_prop_object(10103005)
set_pos(prop001 , {3.754,0.814,10.385})
set_enable_auto_lookat(Actor003,false)
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004,false)
Hide(Actor004)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110061_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110061_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_002)
	InitializeTemplateRandomCamera110061_02()
	InitializeTemplate110061_02()
-- ▼直接出力
Hide(Actor001)
prop001 = setup_prop_object(10103005)
set_pos(prop001 , {3.754,0.814,10.385})

-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
Appear(Actor003)
-- ▲直接出力
-- ▼直接出力
Appear(Actor004)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
setup_small_camera_start(Camera001)
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:えーと…<br>あ、あったあった、これだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_01030002")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk(Actor002,Camera002,EntryData110061_03_07,CameraAssetBundleName110061_03,CameraPos110061_03_107)
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:あっ、ノワール
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_01030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:もしかしてラシアも？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_01030005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:はい、朝に話したあとから<br>あの物語がどうしても読みたくなって
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_01030006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺もだ<br>…せっかくだし、一緒に読もうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_01030007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力

	--★★ラシア★★:ふふっ、ぜひ
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_01030008")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
template2()
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",1.0)
keep_delay_ik_lookat(Actor004,Actor003,"J_Head",1.0)
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ラシア_2★★:悲しい境遇の女の子が<br>あるとき優しい魔法使いに魔法をかけてもらって
	Talk(Actor004,"CHRNAME_RASIA","speech","L","CO_101037_01030010")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定3")
-- ▲直接出力

	--★★ラシア_2★★:きらびやかな<br>お城の舞踏会に参加する、っていうお話でしたね
	Talk(Actor004,"CHRNAME_RASIA","speech","L","CO_101037_01030011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール_2★★:女の子はお城の王子様と仲良くなるんだけど<br>魔法が解けてしまう
	Talk(Actor003,"CHRNAME_NOIR","speech","L","CO_101037_01030012")


	--★★ノワール_2★★:家に帰って悲しむ女の子の前に<br>王子様が彼女の靴を持って現れる…
	Talk(Actor003,"CHRNAME_NOIR","speech","L","CO_101037_01030013")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ノワール_2★★:そうだそうだ、こんな話だった<br>久々に読んだよ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","CO_101037_01030014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ラシア_2★★:あなたの手袋…ボロボロですね
	Talk(Actor004,"CHRNAME_RASIA","speech","L","CO_101037_01030016")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール_2★★:ああ、ずいぶん長いあいだ使ってるんだ、これ<br>そろそろ買い替えたほうがいいかな
	Talk(Actor003,"CHRNAME_NOIR","speech","L","CO_101037_01030017")

-- ▼直接出力
PlayPartVoice("ラシア", "納得")
-- ▲直接出力

	--★★ラシア_2★★:どんな手袋が欲しいとか<br>どのお店で買おうかとか決めているんですか？
	Talk(Actor004,"CHRNAME_RASIA","speech","L","CO_101037_01030018")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力

	--★★ノワール_2★★:いやー…恥ずかしながら<br>俺、そういうのに無頓着でさ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","CO_101037_01030019")

	change_face(Actor003,"Smile")

	--★★ノワール_2★★:適度に質が良くて、値段もそこそこなら<br>どこの店のものでもいいかなって思ってる
	Talk(Actor003,"CHRNAME_NOIR","speech","L","CO_101037_01030020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ラシア_2★★:だったら私、いいお店を知っています<br>今度案内しましょうか？
	Talk(Actor004,"CHRNAME_RASIA","speech","L","CO_101037_01030021")

-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力

	--★★ラシア_2★★:今朝の靴のお礼に
	Talk(Actor004,"CHRNAME_RASIA","speech","L","CO_101037_01030022")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール_2★★:本当か？<br>ぜひお願いするよ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","CO_101037_01030023")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア_2★★:わたしはだいたい学園の前庭にいますから<br>都合の良いときに声をかけてください
	Talk(Actor004,"CHRNAME_RASIA","speech","L","CO_101037_01030024")

-- ▼直接出力
local trustParam = set_communication_acquired("ラシア_コミュランク", "ラシア_親密度")
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
setup_prop_object_preload(10103005)
setup_prop_object_preload(10103005)
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_03)
	system.PreLoadRequest(CameraAssetBundleName110061_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
