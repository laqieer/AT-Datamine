-- このluaスクリプトは、MA_01B112_45.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_505_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115119)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401016","001","401016001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:プレゼントを配るの、手伝おうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_450002")

	PlayAction(Actor002,"to Greet_one")

	--★★ギネヴィア★★:あら、ノワール<br>包装はもう終わったの？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B112_450003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ<br>伊達に円卓の騎士を名乗ってないさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_450004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:プレゼント包装に円卓関係ある？<br>卓上の作業は得意だよっていう高位なジョーク？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B112_450005")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:それはそうと…<br>スノードン遠征、お疲れ様
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B112_450006")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:あなたが聖杯を手に入れてくれたおかげで<br>ローマ…ルーシャスを退けることができた
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B112_450007")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:俺だけの力じゃないよ<br>ルーシャスを追い詰められたのは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_450008")


	--★★ノワール★★:君やガウェインたち<br>ローマ対策班の働きがあってこそだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_450009")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:でも…さらわれちゃって<br>わたし、まるでお姫様みたいね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B112_450010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:…コルベニック城まで<br>助けに来てくれたことも感謝してる
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B112_450011")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:お飾りにしようと買い上げた傭兵が<br>いつの間にか国の英雄になっちゃった
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B112_450012")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:君の目利きが良かったんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_450013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:もうわたしには似合わないほど<br>遠くに行っちゃったみたい
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B112_450014")

	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("子供_女2", "挨拶")
-- ▲直接出力

	--★★子供（女）★★:でんかー<br>わたしにはなにをくれるのー？
	Talk(Actor003,"NPCNAME_0077","speech","N","MA_01B112_450015")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:そ、そうだった、プレゼント配りの途中だった<br>ノワール、またあとでね！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B112_450016")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115119)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401016","001","401016001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
