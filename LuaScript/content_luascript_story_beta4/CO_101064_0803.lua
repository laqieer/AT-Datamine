-- このluaスクリプトは、CO_101064_0803.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_506_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110101_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110101_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_008)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401014","001","401014001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401020","001","401020001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401021","001","401021001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Worry")

	--★★リアム★★:それで…なにからお話ししましょうか
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08030002")


	--★★ノワール★★:さっきの人って昔の仲間だよな？<br>黒牙団っていうのは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_08030003")


	--★★リアム★★:かつて私が所属していた…いえ<br>率いていたグループの名前です
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08030004")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:率いてた！？<br>確かに、さっきの人もリーダーって言ってたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_08030005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★リアム★★:いつの間にか、ですがね
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08030006")

	PlayAction(Actor002,"to  Std_Talk")

	--★★リアム★★:戦争の余波で故郷を失い<br>家族と生き別れ、居場所を失くした私は
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08030008")


	--★★リアム★★:世界のすべてを憎むようになりました
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08030009")


	--★★リアム★★:生活を守るため、自由を手に入れるため<br>ほうぼうへケンカを売る毎日
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08030010")


	--★★リアム★★:そうしているうちに私の周りには<br>似たような境遇の者たちが集まってきて…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08030011")


	--★★リアム★★:黒牙団が出来上がりました
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08030012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:あのひと、言ってたな<br>「黒牙団は家だった」って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_08030013")


	--★★リアム★★:そうですね<br>私たちは一種の家族だったのかもしれません
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08030015")


	--★★リアム★★:生き残るため、寂しさをごまかすために<br>互いに肩を寄せ合った
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08030016")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★リアム★★:でも結局、私たちは世間のはみだし者たちです<br>できたのは周りに対して反発することだけ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08030017")


	--★★リアム★★:争いでなにもかもを失った私が生み出せたのは<br>ちっぽけなイザコザばかりでした
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08030018")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:前に話してた、町の有力者の息子に<br>喧嘩を売ったっていうのもそのひとつか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_08030019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★リアム★★:ええ。向こうは報復のために<br>大勢の傭兵を雇って我々を襲撃させました
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08030020")


	--★★リアム★★:その襲撃で黒牙団は壊滅状態となり<br>私も身を隠さざるを得なくなったのです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08030021")


	--★★ノワール★★:それで教会に匿われたんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_08030022")

	change_face(Actor002,"Surprise")

	--★★リアム★★:…街の方がいらしたようですね<br>なにやら困ったことがあった様子
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08030024")

	PlayAction(Actor003,"to  Std_Talk")

	--★★市民（女）②★★:司祭様、聞いてください！
	Talk(Actor003,"NPCNAME_0183","speech","N","CO_101064_08030026")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★市民（女）②★★:最近、街にガラの悪い人たちが<br>増えて困っているんです
	Talk(Actor003,"NPCNAME_0183","speech","N","CO_101064_08030027")

	PlayAction(Actor005,"to  Std_Worry")

	--★★市民（中年男）★★:ボクなんか路地裏に連れ込まれて<br>危うくカツアゲされそうになったんですよ！
	Talk(Actor005,"NPCNAME_0178","speech","N","CO_101064_08030028")

	PlayAction(Actor004,"to  Std_Worry")

	--★★市民（中年女）★★:わたしはお店でナンクセ付けられて
	Talk(Actor004,"NPCNAME_0184","speech","N","CO_101064_08030029")


	--★★市民（中年女）★★:やめてくれって言おうとしたら<br>「黒牙団に逆らう気か！」って…
	Talk(Actor004,"NPCNAME_0184","speech","N","CO_101064_08030030")

	PlayAction(Actor006,"to  Std_Talk")

	--★★市民（中年男）②★★:俺も街で突然からまれて
	Talk(Actor006,"NPCNAME_0179","speech","N","CO_101064_08030031")


	--★★市民（中年男）②★★:「黒牙団に刃向かうとは<br>いい度胸だー！」みたいな？
	Talk(Actor006,"NPCNAME_0179","speech","N","CO_101064_08030032")


	--★★リアム★★:想像以上に黒牙団の<br>被害が広がっているということですか
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08030033")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★リアム★★:困りましたね…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_08030034")

-- ▼直接出力
local trustParam = set_communication_rankup("リアム_コミュランク", "リアム_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
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
	load_area_scene_preload(110101)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401014","001","401014001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401020","001","401020001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401021","001","401021001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
