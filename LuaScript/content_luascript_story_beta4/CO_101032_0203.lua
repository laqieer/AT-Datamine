-- このluaスクリプトは、CO_101032_0203.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_mcfc_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_020_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
keep_ik_lookat(Actor004,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401029","001","401029001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ガレス", "挨拶")
-- ▲直接出力

	--★★ガレス★★:木の実をすりつぶして、山菜と和えてみた食べてみてくれ！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02030002")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:美味しい！木の実の甘さが山菜特有の苦みやぬめりを調和してくれてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_02030004")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:これなら、いくらでも食べられるぞ！ガウェインもきっと美味いって言うはず！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_02030005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガレス★★:この木の実、食べられたんだなあ知らなかった
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02030006")

-- ▼直接出力
PlayPartVoice("グリフレット", "肯定2")
-- ▲直接出力

	--★★料理人★★:そのまま食べるヤツはあまりいねえだろうな<br>食いにくいし
	Talk(Actor004,"NPCNAME_0260","speech","L","CO_101032_02030007")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★料理人★★:でも、薬味としては<br>いろんな料理に合うんだな、これが
	Talk(Actor004,"NPCNAME_0260","speech","L","CO_101032_02030008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ガレス★★:教えてくれてありがとうこれで兄さんに山菜を食べさせられそうだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02030009")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わざわざ森の奥まで来た甲斐があったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_02030011")

-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力

	--★★ガレス★★:うんオードブルはこれにしようと思う
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02030012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "笑い")
-- ▲直接出力

	--★★リオネス★★:賛成だ！美味いからな！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_02030013")

-- ▼直接出力
PlayPartVoice("ガレス", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:それにしても、まだまだわたしの知らない料理がたくさんあるんだな
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02030014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガレス★★:ときどきこうやってキッチンの外に出てみることは大事だな
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02030015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:よ～し！早速帰って次のメニューを考えよう～！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_02030017")

	open_cutin(2,1)
	on_cutin(1,Actor001,"Smile")
	on_cutin(2,Actor003,"Smile")

	--★★ノワール/リオネス★★:おーっ！
	Talk(Actor005,"CHRNAME_NOIR_LYONESS","speech","N","CO_101032_02030018")

	close_cutin()
-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ガレス_ランクアップ2_4")
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
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401029","001","401029001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
