-- このluaスクリプトは、EA_001_011.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_02","110901_02_h")
Include("content_adv_advsmall_110901_02","Template110901_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110901_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110901_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_005)
	InitializeTemplateRandomCamera110901_02()
	InitializeTemplate110901_02()
-- ▼直接出力
load_image("insert_001", "content_still_10305002_image", "103050020_StillImage")
show_image("insert_001", 0.0, 0.0, 0 ,true,false) 
set_position_image(-120, 0)
 --move_to_image(0,0,20,2)
move_to_image(0,0,15,0)
-- ▲直接出力
-- ▼直接出力
load_image("insert_002", "content_still_10304006_image", "103040060_StillImage")

-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_2DOnly("101018","001","101018001")
	Actor007 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()

	change_face(Actor006,"Laugh")

	--★★ラグネル★★:いっつもドンマイって感じだよ
	Talk(Actor006,"CHRNAME_RAGNAR","simple","L","EA_001_011002")

	change_face(Actor006,"Normal")

	--★★ラグネル★★:お気に入りのかわいいアウターなのに<br>サイズ感が合わなくて落ち着かない、とか
	Talk(Actor006,"CHRNAME_RAGNAR","simple","L","EA_001_011003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラグネル★★:新品なのに着れずじまい<br>だからもう眺めてるだけでもいいかな～とか
	Talk(Actor006,"CHRNAME_RAGNAR","simple","L","EA_001_011004")


	--★★テロップ★★:その経験が<br>いまのラグネルさんを構築していると？
	Talk(Actor007,"telop","simple","N","EA_001_011006")


	--★★ラグネル★★:うん。みんなさ<br>好きでも合わないことってあるよね
	Talk(Actor006,"CHRNAME_RAGNAR","simple","L","EA_001_011007")

	change_face(Actor006,"Laugh")

	--★★ラグネル★★:でもせめて自分が好きなものを…こう、並べてさ<br>みんなに知ってもらえるだけでも嬉しいじゃん
	Talk(Actor006,"CHRNAME_RAGNAR","simple","L","EA_001_011008")


	--★★ラグネル★★:夜が不安だった幼いころ…かわいいぬいぐるみが<br>みんなを笑顔にしてくれたように
	Talk(Actor006,"CHRNAME_RAGNAR","simple","L","EA_001_011009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★ラグネル★★:あたしもそれができないかなって思ってるんだ<br>どうやったらいいかは考え中だけど（笑）
	Talk(Actor006,"CHRNAME_RAGNAR","simple","L","EA_001_011010")


	--★★テロップ★★:美学ですね（笑）<br>いまそうしてあげたい相手はいますか？
	Talk(Actor007,"telop","simple","N","EA_001_011011")

-- ▼直接出力
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
show_image("insert_002", 0.0, 0.0, 0 ,true,false) 
set_position_image(0,36)
move_to_image(0,-36,15,2)
 --setup_small_camera_start()
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★ラグネル★★:話題の転校生、いるよね<br>彼のこと…ちょっと気になってるんだ
	Talk(Actor006,"CHRNAME_RAGNAR","simple","L","EA_001_011012")


	--★★テロップ★★:先月…入学早々、円卓の騎士となった<br><ruby=ラ・コート・マルタイユ>『不格好なコート』</ruby>ですね？
	Talk(Actor007,"telop","simple","N","EA_001_011014")


	--★★ラグネル★★:彼…いつだか<br>「置き去りにされたくない」って言ってた
	Talk(Actor006,"CHRNAME_RAGNAR","simple","L","EA_001_011016")

	change_face(Actor006,"Sad")

	--★★ラグネル★★:なにに焦ってるんだろ。わかんなくて
	Talk(Actor006,"CHRNAME_RAGNAR","simple","L","EA_001_011017")


	--★★ラグネル★★:でも、なにかを追っかけるために<br>ムリしていきなり大役背負って──
	Talk(Actor006,"CHRNAME_RAGNAR","simple","L","EA_001_011018")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力

	--★★テロップ★★:似合ってませんものね<br>戦場で来ている金色のコートも含めて
	Talk(Actor007,"telop","simple","N","EA_001_011019")

	change_face(Actor006,"Normal")

	--★★ラグネル★★:着心地…悪くないのかなあ
	Talk(Actor006,"CHRNAME_RAGNAR","simple","L","EA_001_011020")

-- ▼直接出力
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
hide_image(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME+STILL_PASSIVE_AFTER)
 --setup_small_camera_start(RndCamera008)
-- ▲直接出力

	--★★テロップ★★:それでは最後となりますが<br>五月祭に向けて意気込みを伺いたいです
	Talk(Actor007,"telop","simple","N","EA_001_011021")


	--★★テロップ★★:城下町に出店する屋台…<br>隣は素人料理<ruby=サークル>同好会</ruby>だそうですね
	Talk(Actor007,"telop","simple","N","EA_001_011022")


	--★★テロップ★★:エースのガレス氏擁する調理部に勝とうと<br>炎を上げる派手な料理を用意しているようですが
	Talk(Actor007,"telop","simple","N","EA_001_011024")

	change_face(Actor006,"Smile")

	--★★ラグネル★★:それすごいね！見てみたいなっ<br><ruby=サークル>同好会</ruby>同士、お祭りは知名度を上げるチャンス！
	Talk(Actor006,"CHRNAME_RAGNAR","simple","L","EA_001_011025")


	--★★ラグネル★★:みんなでたのしもー！
	Talk(Actor006,"CHRNAME_RAGNAR","simple","L","EA_001_011026")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力

	--★★テロップ★★:『新聞部<br>臨時特集企画』
	Talk(Actor007,"telop","simple","N","EA_001_011027")


	--★★テロップ★★:『五月祭で摘み取られる日陰者たち<br>廃部寸前？かわいそうな手芸サークルに迫る！』
	Talk(Actor007,"telop","simple","N","EA_001_011028")

	EndPlay()
end

function TalkDirect(controllerId, talkerNameTag, frameType, dir, textId)
	-- 必要があれば前回開いたウインドウを閉じる
	if CheckIfNeedClose(controllerId, frameType, dir) == true then
		CloseTalkWindow()
	end
	-- 必要があればウインドウを開く
	if CheckIfNeedOpen(controllerId, frameType, dir) == true then
		OpenTalkWindow(talkerNameTag, controllerId, frameType, dir)
	end
	-- カメラワークのための通知
	manager.CloseupUpExclusiveCamera(controllerId)
	lastTalkControllerId = controllerId

	-- テスト用
	message_direct(textId)
	-- 本番用
    -- message(textId)

	-- しゃべった人のモーションを戻す
	PlayAction(lastTalkControllerId, "to Std_Loop")
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end
