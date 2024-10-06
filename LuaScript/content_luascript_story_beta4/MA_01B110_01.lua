-- このluaスクリプトは、MA_01B110_01.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_04","110141_04_h")
Include("content_adv_advsmall_110141_04","Template110141_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_SitController","to Sit01_Loop",CameraAssetBundleName110141_04,CameraPos110141_04_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName110141_04,CameraPos110141_04_001)
	InitializeTemplateRandomCamera110141_04()
	InitializeTemplate110141_04()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("モルガン", "納得")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルガン★★:綺麗な色ね？
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01B110_010002")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガラハッド★★:え、な、なにがだ？
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_010003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルガン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルガン★★:貴方の色。銀の色
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01B110_010004")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "照れ")
-- ▲直接出力
	change_face(Actor001,"Shy")

	--★★ガラハッド★★:が、ガラハッドを褒めても、何も出ないぞ
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_010005")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★モルガン★★:身構えないで欲しいなあ<br>おだてたつもりはないのにぃ
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01B110_010006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ガラハッド★★:ハッ！アーサー王に頼まれたのか…！<br>僕を引き込んで銀卓を篭絡しようとか…！？
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_010007")

-- ▼直接出力
 --PlayPartVoice("モルガン", "挨拶")
-- ▲直接出力

	--★★モルガン★★:ガラハッドくぅん…貴方はもっと<br>自分の魅力に気づいた方が良いわよ？
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01B110_010009")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力

	--★★ガラハッド★★:ガラハッドの、魅力…？
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_010010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルガン★★:怪我な～し。うん。大事にされてきたのね<br>貴方のカラダも…貴方が纏う甲冑も
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01B110_010012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ガラハッド★★:当たり前だ！<br>お爺様も銀卓の皆も大事にしてくれた！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_010013")

-- ▼直接出力
 --PlayPartVoice("モルガン", "笑い")
-- ▲直接出力

	--★★モルガン★★:銀色ってイイ色よね<br>貴方のは凄く磨き上げられてるのがわかる
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01B110_010014")


	--★★モルガン★★:傷も全然なくて
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01B110_010015")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガラハッド★★:…それ、は…
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_010016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★モルガン★★:…？ご、ごめんなさい<br>なにか気に障ること言ったかしら
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01B110_010018")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ガラハッド★★:い、いや
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_010019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルガン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルガン★★:銀色。ぴかぴかで汚れひとつない<br>それって素敵、うらやましいぐらいよ
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01B110_010020")

	change_face(Actor001,"Shy")

	--★★ガラハッド★★:…あ、貴方も、モルガン、貴方も…あの
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_010021")

-- ▼直接出力
 --PlayPartVoice("モルガン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルガン★★:なあに？
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01B110_010022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガラハッド★★:き、綺麗だ
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_010023")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:触れられても、ぜんぜん、嫌じゃない<br>こんなの銀卓の皆やお爺様…姉上ぐらいなのに…
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_010024")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("モルガン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルガン★★:もお…褒めても何も出ないわ～？
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01B110_010026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ガラハッド★★:おだてたつもりはない
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_010028")


	--★★モルガン★★:嬉しい言葉を返されちゃった…<br>本当、貴方の銀色はまるで──
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01B110_010029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガラハッド★★:まるで？
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B110_010030")

-- ▼直接出力
 --PlayPartVoice("モルガン", "笑い")
-- ▲直接出力

	--★★モルガン★★:まるで、鏡みたいね
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01B110_010032")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
