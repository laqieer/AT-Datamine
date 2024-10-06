-- このluaスクリプトは、MA_01107_04.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_014_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101009","003","101009003","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101050","001","101050001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","003","101012003","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
	change_face(Actor002,"Smile")

	--★★ブライアン★★:もう帰ってくんなよ～
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040002")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ヒドいなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_040004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Normal")

	--★★ブライアン★★:カビくせえ生活を強いちまった<br>念願叶えば帰って来る必要なんざねえよ
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040005")

	change_face(Actor002,"Smile")

	--★★ブライアン★★:夢はリッパな円卓の騎士、だろ？<br>ブッ殺して奪っちまえばイイんだ、席を
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040006")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:大切な人を殺してまで<br>円卓の騎士になりたくない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_040007")

	change_face(Actor002,"Sad")

	--★★ブライアン★★:…
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040008")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Anger")

	--★★ブライアン★★:…咎人として失踪していた円卓の騎士ブルーノが<br>逃亡の果てで粛清されたって話題だ
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040009")


	--★★ブライアン★★:ブルーノは妖精守護を任されていた円卓の騎士<br>それゆえ素性は一般には知れぬままだが
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040010")


	--★★ブライアン★★:その功績が認められ<br>あらたな円卓の騎士になったのが…
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
change_face(Actor003,"Sad")
-- ▲直接出力

	--★★ノワール★★:…ランスロット
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_040012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ブライアン★★:ブルーノの咎<br>世間に伏せられてはいるが…
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040013")


	--★★ブライアン★★:おめえらから聞いた話じゃあ<br>ランスロットもその咎を知ってる
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ブライアン★★:『妖精殺し』の咎…とみて間違いねえ<br>その大罪人を討ったとなりゃ大金星だ
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040015")


	--★★ブライアン★★:円卓の席の後釜を狙って<br>ブルーノを追ってたとしてもおかしかねえ
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040016")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:そんなヤツじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_040017")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ブライアン★★:…ノワール。よく聞いてくれ
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040018")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
reserve_eyesync(Actor001,"Close")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:信じられないんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_040020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
reserve_eyesync(Actor001,"Auto")
-- ▲直接出力

	--★★ブライアン★★:ランスロットは最強の騎士だ
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040021")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ブライアン★★:カレドニアのライエンス率いる王の軍勢を<br>単騎で百人以上蹴散らしたって話もある
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040022")

	change_face(Actor002,"Normal")

	--★★ブライアン★★:そのおかげなのかなんなのか知らねえが<br>よっぽどランスロットが怖かったのかねえ…
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040023")


	--★★ブライアン★★:いまやカレドニアの前線兵力は傭兵に頼りつつ<br>バルバロイだかっつう化け物も幅を利かせ始めた
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★ブライアン★★:一国の体制すら変えちまったのかもしんねえ<br>ランスロットってのは天才だ
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040025")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:…違う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_040027")

-- ▼直接出力
reserve_eyesync(Actor002,"Close")
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ブライアン★★:不公平だね、世のなか
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040028")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:努力家なんだよ、ランスロットは<br>俺が良く知ってる。だから追いつけない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_040029")

-- ▼直接出力
reserve_eyesync(Actor002,"Auto")
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ブライアン★★:…じゃあ、勝てる見込みは？<br>自らの師匠すら殺しちまう最強騎士に
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ブライアン★★:ブルーノは気に食わねえが気のイイヤツで…<br>酒は弱ェが剣じゃ一度も勝てなかった…
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040033")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_040034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad02")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ブライアン★★:オレはライエンス王からお呼びがかかって<br>カレドニア城に戻らなきゃなんねえ
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040035")


	--★★ブライアン★★:…オレはもう守ってやれねえ
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040037")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ブライアン…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_040038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブライアン★★:生きてくれよノワール。ディナタンとともに<br>ヤバくなったら逃げちまっていい
	Talk(Actor002,"CHRNAME_BRIAN","speech","L","MA_01107_040039")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
change_face(Actor003,"Normal")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:………ありがとうブライアン。本当に
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_040040")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力

	--★★テロップ★★:ようやく見つけた絆のほつれ
	Talk(Actor004,"telop","narration","N","MA_01107_040041")

	PlayAction(Actor001,"to Greet_one")
	change_face(Actor001,"Normal")

	--★★ノワール★★:いってきます
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_040042")


	--★★テロップ★★:本当のことを言ってくれ
	Talk(Actor004,"telop","narration","N","MA_01107_040043")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101009","003","101009003","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101050","001","101050001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","003","101012003","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
