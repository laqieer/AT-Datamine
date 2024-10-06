-- このluaスクリプトは、CO_101064_1004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101020013)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401021","001","401021001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★市民（男）★★:ファ～…。あくびが出るくらい楽勝だったな<br>オレら３人だけで問題なかったくらいだ
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_10040002")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★リアム★★:なに言ってやがる<br>連中をノシた数、俺の半分にも満たねえくせに
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10040003")


	--★★市民（男）★★:て、てめえに花を持たせてやったんだよ！<br>オレの気遣いに感謝しやがれ
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_10040004")

	PlayAction(Actor004,"to  Std_Talk")

	--★★市民（中年男）②★★:でもリアム、全然鈍ってなかったな！<br>司祭やってるなんてのはウソなんだろ？
	Talk(Actor004,"NPCNAME_0252","speech","N","CO_101064_10040005")

	change_face(Actor002,"Normal")

	--★★リアム★★:ウソなわけあるか<br>毎日朝早く起きて夜遅くまで働いてんだ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10040006")

	PlayAction(Actor005,"to  Std_Talk")

	--★★市民（中年男）★★:なあ、戻って来いよ<br>また一緒にバカやろうぜ
	Talk(Actor005,"NPCNAME_0251","speech","N","CO_101064_10040007")

	PlayAction(Actor002,"to  Std_No")

	--★★リアム★★:戻らねぇよ<br>「気が変わった」は半分間違いだっつったろ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10040009")

	change_face(Actor002,"Sad")

	--★★リアム★★:俺がいなくなったら<br>誰がハーブ園の手入れすんだ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10040010")

	PlayAction(Actor004,"to  Std_Worry")

	--★★市民（中年男）②★★:…ハーブ園？
	Talk(Actor004,"NPCNAME_0252","speech","N","CO_101064_10040011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★リアム★★:お前らみてえなガサツなヤツらにゃ<br>わかんねえハナシだよ、気にすんな
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10040012")

	PlayAction(Actor003,"to  Std_Angry")

	--★★市民（男）★★:けっ、ハーブだかソースだか知らねーが<br>ハンパもんは一生戻らなくて結構だ！
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_10040013")


	--★★市民（中年男）★★:まぁ、昔っから<br>リアムは言い出したらきかないからな
	Talk(Actor005,"NPCNAME_0251","speech","N","CO_101064_10040014")


	--★★市民（中年男）②★★:寂しいけど仕方ねえ
	Talk(Actor004,"NPCNAME_0252","speech","N","CO_101064_10040015")

	PlayAction(Actor003,"to  Std_No")

	--★★市民（男）★★:あとで戻るって言ってきても<br>てめえの席なんかねえからな！！
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_10040016")

	change_face(Actor002,"Anger")

	--★★リアム★★:戻らねーよ、しつっけえな！
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10040017")


	--★★市民（男）★★:へへっ
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_10040018")

	change_face(Actor002,"Smile")

	--★★リアム★★:ふっ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10040019")

	PlayAction(Actor003,"to Greet_one")

	--★★市民（男）★★:あばよ、司祭リアム<br>カミサマによろしくな
	Talk(Actor003,"NPCNAME_0240","speech","N","CO_101064_10040020")

	PlayAction(Actor002,"to Greet_one")

	--★★リアム★★:…あばよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10040022")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:よかったのか？あの人たちといるときの<br>リアムさん、楽しそうだったけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_10040024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★リアム★★:いいんだよ<br>あいつらにはあいつらの生きかたってのがある
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10040026")

	change_face(Actor002,"Smile")

	--★★リアム★★:こっちはこっちで楽しくやろうぜ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10040027")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:リアムさん、リアムさん<br>口調が戻ってない…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_10040028")

	change_face(Actor001,"Normal")

	--★★ノワール★★:このハーブ、使うか？<br>気持ちが落ち着くと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_10040029")

	PlayAction(Actor002,"to  Std_Talk")

	--★★リアム★★:悪ぃな、ノワっちゃん
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10040030")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（リアムさんまで…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101064_10040031")

	change_face(Actor002,"Normal")

	--★★リアム★★:…失礼
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10040032")

	change_face(Actor001,"Normal")

	--★★ノワール★★:さっきの人たち<br>大聖堂に来てくれるといいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_10040033")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★リアム★★:そうですね<br>とはいえ、難しいかもしれません
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10040034")


	--★★リアム★★:なにしろ、拳を交えてから説教をする<br>司祭が相手ですからね
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10040035")

	change_face(Actor001,"Smile")

	--★★ノワール★★:ははっ<br>でも、さっきのリアムさん恰好よかったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_10040036")


	--★★ノワール★★:きっと、先生にも負けないくらいにさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_10040037")

	PlayAction(Actor002,"to  Std_No")

	--★★リアム★★:いえ、先生に比べれば<br>私などまだまだ未熟です
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10040038")

	change_face(Actor001,"Normal")

	--★★ノワール★★:称賛の言葉を素直に受け取ることも<br>礼儀のひとつじゃなかったっけ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_10040039")

	change_face(Actor002,"Surprise")

	--★★リアム★★:これは…参りましたね
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10040041")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★リアム★★:ありがとうございます、ノワールさん
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10040043")

	change_face(Actor001,"Smile")

	--★★ノワール★★:どういたしまして
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_10040044")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★リアム★★:さて、そろそろ大聖堂に戻りましょうか
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10040045")

	change_face(Actor002,"Smile")

	--★★リアム★★:今日もみなさんが悩みの相談に来るはずですよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_10040046")

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
	load_duel_scene_preload(101020013)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401021","001","401021001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
