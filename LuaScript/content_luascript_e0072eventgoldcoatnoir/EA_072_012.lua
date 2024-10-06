-- このluaスクリプトは、EA_072_012.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_008)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_002)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
set_pos(Actor003, {-0.884, -3.764, -0.369})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115907)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("ディナタン_006","0009")
-- ▲直接出力

	--★★ディナタン★★:兄さんの旅程はね
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_072_0120003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:この学園を出て、アストラットへ行って<br>里帰りしているラヴェインさんに挨拶をして…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_072_0120004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:そのあと<br>キャメリアードを見て──
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_072_0120005")

-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0055")
-- ▲直接出力

	--★★ランスロット★★:ついていかなかったのか？<br>ノワールに
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_072_0120006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:ランス兄ちゃんこそ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_072_0120007")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0023")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:………俺では、あいつの喪失感を<br>埋めることができない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_072_0120008")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ディナタン★★:できないよ。誰にも
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_072_0120009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ディナタン2★★:誰も覚えていない…<br><dot>兄さんしか覚えていないひと</dot>が、いる…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_072_0120010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ディナタン_006","0025")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:だから私は<br>ここで待ってるの
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_072_0120012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:兄さんからね、制服を預かったんだ<br>それを繕いながら待っていようと思うの
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_072_0120013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0038")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ランスロット★★:…なら俺もここで<br>あいつの留守を預かるか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_072_0120014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ディナタン★★:兄さんが<br>いつ帰って来てもいいようにね
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_072_0120015")

-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0053")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:………その制服がなくて<br>あいつは大丈夫なのか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_072_0120016")

-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:え？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_072_0120017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")

	--★★ランスロット★★:私服とか、あるのか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_072_0120019")

	PlayAction(Actor001,"to Sit01_BA01")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0014")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:ないっぽいよ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_072_0120020")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0014")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ランスロット★★:な、ないっぽいのか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_072_0120021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ディナタン★★:だから傭兵時代の服、着ていったみたい
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_072_0120022")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:残ってたのか？<br>ずいぶんボロボロだったはずだが…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_072_0120023")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ディナタン★★:なんかね、不思議とキレイだったよ<br>兄さんが手入れしたのかなと思ったんだけど──
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_072_0120024")

-- ▼直接出力
setup_small_camera_end()
CloseTalkWindow()
on_camera(Camera003)
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ディナタン_006","0034")
-- ▲直接出力

	--★★ディナタン2★★:なんだか、丈が合っていなかった気がして
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_072_0120026")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
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
	load_area_scene_preload(115907)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
