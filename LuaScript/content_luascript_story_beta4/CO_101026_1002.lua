-- このluaスクリプトは、CO_101026_1002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	Camera003 = SetTemplate("Actor003",-58,CharaPos110051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_004)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
-- ▼直接出力
turn_chara(Actor001,122.713,0)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002, Actor003, "J_Head")
lookat_delay_weight(Actor002,0.8,0.08,0.4,0.2,1)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:…というわけなんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_10020002")

-- ▼直接出力
PlayPartVoice("ケイ", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ケイ★★:果てなき森とリムニーナ村が繋がっていた、か<br>にわかには信じがたい話だな
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_10020003")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "納得")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ケイ★★:ノワールにパーシヴァル<br>お前たちの見解を聞かせてもらえるか？
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_10020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:果てなき森…いや妖精の森は<br>導きを得ぬ人間が足を踏み入れた場合
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_10020005")


	--★★ノワール★★:果てなく迷い<br>里に辿りつくことすらできないといわれている
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_10020006")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:恐らくは空間のねじれのようなものができていて<br>いくつかの場所に繋がっているんじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_10020007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:そして妖精たちは<br>自由にその空間を行き来できたんだと思うよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10020008")

-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:その空間を人間は「妖精の通り道」と呼び…
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_10020009")

	PlayAction(Actor003,"to  Std_Worry")
	change_face(Actor003,"Sad")

	--★★ケイ★★:その出口のひとつが<br>リムニーナ村だったということか
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_10020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力

	--★★パーシヴァル★★:ボクたちの仮説でしかないし<br>実証のしようもない、トンデモ話だけどね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10020011")


	--★★パーシヴァル★★:事実、ボクたちはあのあと森に入ったけど<br>果てなき森に戻ることはできなかった
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10020012")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "落胆")
-- ▲直接出力

	--★★パーシヴァル★★:従来どおり<br>海を渡って学園まで帰ってくることになったよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10020014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ケイ★★:なんとも不思議な話だが<br>なにせ妖精にまつわる伝説なのだからな
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_10020015")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ケイ★★:ところで森からリムニーナ村に出たということは<br>妖精の生き残りというのは…
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_10020016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:想像のとおりだと思う<br>妖精の生き残りは、もういない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_10020017")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayPartVoice("ケイ", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ケイ★★:そうか…
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_10020018")

-- ▼直接出力
wait_time(0.2)
CloseTalkWindow()
wait_time(1.2)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "納得")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ケイ★★:ふたりともご苦労だった<br>これで今回の任務は完遂としよう
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101026_10020020")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_パーシヴァル_ランクアップ10_3")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
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
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
