-- このluaスクリプトは、MA_01108_58.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111016_03","111016_03_h")
Include("content_adv_advsmall_111016_03","Template111016_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111016_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111016_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111016_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111016_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_005)
	InitializeTemplateRandomCamera111016_03()
	InitializeTemplate111016_03()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111016)
	Actor001 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101056","001","101056001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★アーサー★★:世話になった<br>ぺレス王
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01108_580002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ペレス★★:聞き及んだぞ<br>継承者の決断を
	Talk(Actor002,"CHRNAME_PEREZ","speech","L","MA_01108_580003")


	--★★ペレス★★:そして大敵の台頭…
	Talk(Actor002,"CHRNAME_PEREZ","speech","L","MA_01108_580004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ペレス★★:継承者が完全に覚醒した以上<br>これが最後の戦いとなろう
	Talk(Actor002,"CHRNAME_PEREZ","speech","L","MA_01108_580005")


	--★★ペレス★★:我らが力を合わせねばならぬ時期が<br>来ていることは理解しておるつもりだ
	Talk(Actor002,"CHRNAME_PEREZ","speech","L","MA_01108_580006")

	PlayAction(Actor001,"to Bow")
	change_face(Actor001,"Sad")

	--★★アーサー★★:お気遣い感謝いたします<br>そのお気持ちだけでじゅうぶんです
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01108_580007")

	change_face(Actor003,"Surprise")

	--★★ノワール★★:アーサー…？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01108_580008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:妖精や伝承…不確かなものにすがり続け<br>ペレス王にも心労をかけた
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01108_580009")


	--★★アーサー★★:確かな伝説を<br>人が創っていかねばなるまい
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01108_580010")


	--★★アーサー★★:最初の武器が導いたノワールのＧＳと<br>聖杯伝承にすべては懸かっている…
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01108_580012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:これまでと何も変わらないよね、兄さん<br>私たち、ずっと一緒だったから
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01108_580014")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Anger")

	--★★ディナタン★★:私たちが道を選んだだけ<br>いまは兄さんの…盾にも剣にもなれる
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01108_580015")


	--★★ディナタン★★:ほつれても、ほつれても
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01108_580016")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111016)
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101056","001","101056001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111016_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
