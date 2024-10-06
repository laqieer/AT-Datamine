-- このluaスクリプトは、MA_01108_10.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_05","110071_05_h")
Include("content_adv_advsmall_110071_05","Template110071_05_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_05_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_05_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_05_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_05_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_05_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_008)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110071_05_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_007)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110071_05_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_004)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110071_05_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_003)
	InitializeTemplateRandomCamera110071_05()
	InitializeTemplate110071_05()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor008")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")

	--★★ルーシャス★★:例えばだ、ギネヴィア
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01108_100002")


	--★★ルーシャス★★:愛や情や絆というものを学園で育んでいるが<br>ソレで世界を救えると思うか？
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01108_100003")


	--★★ギネヴィア★★:リアリストね。意外に
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_100004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ルーシャス★★:ロマンチストだよ。案外ね
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01108_100005")


	--★★ギネヴィア★★:学園で育んだ関係がＧＳの会得に役立つでしょ<br>ＧＳができればバルバロイに勝てるでしょ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_100006")

	PlayAction(Actor003,"to  Std_No")

	--★★ルーシャス★★:そういった表層の勝利の話ではないよ<br>広く大きな世界を救いあげられるかという問題だ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01108_100008")


	--★★ガウェイン★★:そういうデカい規模の問いは<br>我らが救世主にしたらどうっすか？
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","MA_01108_100009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:…ルーシャス<br>あんたは情けで軍を動かしてくれたじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_100011")

	change_face(Actor003,"Smile")

	--★★ルーシャス★★:………クックククク。良い答えだ<br>余と貴様らのキズナが世界を覆すというわけだ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01108_100013")

	PlayAction(Actor005,"to  Std_Talk")

	--★★ラグネル★★:それで？カレドニアへの侵攻準備って聞いたけど<br>具体的になにをするおつもりで？
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","MA_01108_100015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ヴェルナルス★★:ロンディニウムからカレドニアまでの<br>補給線を作る
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","MA_01108_100016")


	--★★ギネヴィア★★:あら。堅実
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_100017")


	--★★ヴェルナルス★★:カレドニアとの戦…一朝一夕で終わりはしまい<br>人員や物資の補給をできるようにしておかねばな
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","MA_01108_100018")

	change_face(Actor003,"Normal")

	--★★ルーシャス★★:とはいえケチな戦いも性に合わぬ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01108_100019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ルーシャス★★:カレドニアの南に<br>サンダーンという港町があるだろう
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01108_100020")


	--★★ルーシャス★★:かの地はカレドニアの喉元<br>食い破れば悲鳴も上がるまい
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01108_100021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:ローマの物量で一気に占領…いいわね<br>これを機に戦いも一気に進展しそう
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_100022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ルーシャス★★:余とそなたの仲も<br>一気に進展しそうだな？
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01108_100023")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:そういうロマンはお控えを
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_100025")

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
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor008")
MobsNo = 0
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
