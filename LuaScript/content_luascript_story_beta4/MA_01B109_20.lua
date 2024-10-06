-- このluaスクリプトは、MA_01B109_20.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",90,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115194)
	Actor001 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力

	--★★トリスタン★★:兜はどうしたんだい？<br>そういえば
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200002")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:…留学は認められた<br>もう眉間を狙われるのはご免こうむりたい
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B109_200003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★トリスタン★★:銀卓騎士ともあろう者が<br>兜を落とされるなんて相当のことだね
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200004")


	--★★トリスタン★★:誰にやられたのかな
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:…なにが言いたい
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B109_200006")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★トリスタン★★:コルベニックが落ちたのは聞いたよ<br>それで、他の銀卓騎士はどうなったんだい？
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200007")


	--★★トリスタン★★:まさかとは思うけれど──
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:言うな！！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B109_200009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★トリスタン★★:ああ…ありがとう
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★トリスタン★★:その反応で<br>なんとなく事情は察したよ
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200011")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "激怒")
-- ▲直接出力

	--★★ガラハッド★★:僕たち銀卓騎士団に負けはない…ッ<br>バルバロイなどの有象無象に屈することは決して
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B109_200012")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Normal")

	--★★トリスタン★★:信じられないな<br>その根拠のない自信が余計にね
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200014")


	--★★トリスタン★★:バルバロイによって聖杯城が落とされたのなら<br>銀卓騎士は敵に侵されたと考えるのが普通だ
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200015")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ガラハッド★★:ありえない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B109_200017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★トリスタン★★:兜を取られたのは<br>キミが銀卓から弾かれたってことだ
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200018")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力

	--★★ガラハッド★★:兜を落としたのはガラハッドの不注意だ…！<br>銀卓騎士団は関係ない！！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B109_200019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★トリスタン★★:あの高価な銀甲冑の一部を落としてしまうとは<br>銀卓騎士としてのキミの誇りが疑われるね
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200020")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:………銀卓騎士団は穢れない<br>人道から外れることは決してない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B109_200021")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "激怒")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★トリスタン★★:根拠が欲しいんだよ<br>確固たる根拠が
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200023")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力

	--★★ガラハッド★★:…身を寄せ合って、互いを守り合って来た<br>あの島で、小さな城の中で唯一の──
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B109_200024")


	--★★ガラハッド★★:…かぞく、だからだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B109_200025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★トリスタン★★:………結論がそれか
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200027")

	change_face(Actor001,"Normal")

	--★★トリスタン★★:家族だから裏切らないとでも？<br>がっかりだね
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:なんだと
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B109_200029")


	--★★トリスタン★★:万能ワードじゃないよ。家族って
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200030")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力

	--★★ガラハッド★★:ひとつの家で寄り合い、助け合うのが家族だ…！<br>たとえ血の繋がりなどなくとも！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B109_200032")

	PlayAction(Actor001,"to  Std_Talk")

	--★★トリスタン★★:「家族の絆はなにがあっても切れない」？<br>「家族はともに暮らさないといけない」？
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200033")


	--★★トリスタン★★:「家族なら助け合うのが当然」？<br>「家族だから多少の暴力も許される」？
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★トリスタン★★:「家族なら」「家族だから」「家族ゆえに」<br>「手を取り、信じ合う」「疑いようもなく」？
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200035")

	PlayAction(Actor001,"to  Std_No")

	--★★トリスタン★★:勘違いだよ、それ
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200036")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:か、家族ごとに色々な関わり合い方があることは<br>理解している…だが銀卓騎士団に限っては──
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B109_200037")


	--★★トリスタン★★:事実、キミを見放したわけだよね？
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200038")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "苦しみ")
-- ▲直接出力

	--★★ガラハッド★★:…っ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B109_200039")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力

	--★★トリスタン★★:今でも心は一緒だと？
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200040")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:無論だ…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B109_200041")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★トリスタン★★:だとすればガラハッド<br>キミも彼らと一緒なのかな
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200042")


	--★★トリスタン★★:キミもバルバロイになってしまうのかな
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200043")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:…どけ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B109_200044")


	--★★ガラハッド★★:ガラハッドは<br>それを確かめに行くんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B109_200046")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★トリスタン★★:背中に気を付けて
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01B109_200048")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115194)
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 0
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
